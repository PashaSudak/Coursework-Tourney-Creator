using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tourney_Creator
{
    public partial class ChangePassForm : Form
    {
        User autUser = new User();
        private UsersDB db = new UsersDB();
        public ChangePassForm(User _autUser)
        {
            InitializeComponent();

            this.autUser = _autUser;

            db.ConnectToSQLiteDB();
        }

        private void changePassButton_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string newPass = textBoxPass.Text.Trim();

            if (newPass.Length < 5)
            {
                MessageBox.Show("Пароль має містити 5 або більше символів",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            else
            {
                int opResult = db.ModifyUserPassword(autUser, login, newPass);

                if (opResult == -1)
                {
                    MessageBox.Show("У вас немає доступа для зміни пароля користувача " + login + "!",
                        "ERROR",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                else if (opResult == 0)
                {
                    MessageBox.Show("Користувача " + login + " не знайденно!",
                        "ERROR",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                else
                {
                    MessageBox.Show("Пароль для " + login + " зміннено успішно!",
                        "Здійсненно",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(autUser);

            this.Close();
            mainForm.Show();
        }
    }
}
