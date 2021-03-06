﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tourney_Creator
{
    public partial class DeleteTeamForm : Form
    {
        TeamsDB db = new TeamsDB();
        User autUser = new User();
        public DeleteTeamForm(User autUser)
        {
            InitializeComponent();

            this.autUser = autUser;
            db.ConnectToSQLiteDB();
        }

        private void deleteTeamButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxTeamName.Text.Trim());

                int result = db.DeleteTeamFromDB(id);

                if (result == 0)
                {
                    MessageBox.Show("Команду не знайденно!",
                        "!!!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    File.AppendAllText("log.txt", "Error. Cant find team.\n");
                }
                else
                {
                    MessageBox.Show("Команду видаленно!",
                        "!!!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    File.AppendAllText("log.txt", "Info. " + autUser.Login + " deleted team with id " + id + ".\n");
                }
            }
            catch
            {
                MessageBox.Show("ERROR: Пусте поле!",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                File.AppendAllText("log.txt", "Error. Empty textBox.\n");
            }
        }

        private void textBoxTeamName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            TeamsForm teamsForm = new TeamsForm(autUser);
            
            this.Close();
            teamsForm.Show();
        }
    }
}
