using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tourney_Creator
{
    public partial class LoginForm : Form
    {
        UsersDB db = new UsersDB();

        public LoginForm()
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
                int id = db.IsLoginAndPasswordCorrect(login, pass);

                if (Convert.ToBoolean(id))
                {
                    User autUser = new User();
                    autUser.Login = login;
                    autUser.Pass = pass;
                    autUser.id = id;
                    autUser.rights = db.getRightsFromId(id);
                    Console.WriteLine(autUser.rights);

                    File.AppendAllText("log.txt", "Info. " + autUser.Login + " logged in.\n");

                    MainForm mainForm = new MainForm(autUser);

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
                    File.AppendAllText("log.txt", "Error. Incorrect login and pass.\n");
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

                File.AppendAllText("log.txt", "Info. Created new account - " + login + ".\n");

                MessageBox.Show("Акаунт створенно",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
