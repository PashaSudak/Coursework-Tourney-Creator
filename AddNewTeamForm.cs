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
    public partial class AddNewTeamForm : Form
    {
        User autUser = new User();
        TeamsDB db = new TeamsDB();
        public AddNewTeamForm(User autUser)
        {
            InitializeComponent();
            this.autUser = autUser;

            db.ConnectToSQLiteDB();
        }

        private void addNewTeamButton_Click(object sender, EventArgs e)
        {
            string name = textBoxTeamName.Text.Trim();
            
            if (name == "")
            {
                MessageBox.Show("Введіть назву команди!",
                    "!!!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            else
            {
                db.AddNewTeam(name);
                MessageBox.Show("Команду " + name + " доданно!",
                    "Успіх",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            TeamsForm teamsForm = new TeamsForm(autUser);

            this.Close();
            teamsForm.Show();
        }

        private void textBoxTeamName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
