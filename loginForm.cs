using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tourney_Creator
{
    public partial class loginForm : Form
    {
        UsersDB db = new UsersDB();
        MainForm mainForm = new MainForm();

        public loginForm()
        {
            InitializeComponent();

            db.ConnectToSQLiteDB();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string pass = textBoxPass.Text.Trim();

            int isExist;

            if (login.Length < 5)
            {
                MessageBox.Show("Логін має містити 5 або більше символів",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            else if (pass.Length < 5)
            {
                MessageBox.Show("Пароль має містити 5 або більше символів",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            else
            {
                isExist = db.IsLoginAndPasswordCorrect(login, pass);
                if (Convert.ToBoolean(isExist))
                {
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Пароль та логін неправильний!",
                        "ERROR",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string pass = textBoxPass.Text.Trim();

            if (login.Length < 5)
            {
                MessageBox.Show("Логін має містити 5 або більше символів",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            else if (pass.Length < 5)
            {
                MessageBox.Show("Пароль має містити 5 або більше символів",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            else
            {
                db.AddNewUser(login, pass);

                MessageBox.Show("Акаунт створенно",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }
    }
}
