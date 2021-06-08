using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tourney_Creator.Forms.DiagramForms;

namespace Tourney_Creator
{
    public partial class MainForm : Form
    {
        User autUser = new User();

        public MainForm(User _autUser)
        {
            InitializeComponent();

            this.autUser = _autUser;
        }

        private void changePassButton_Click(object sender, EventArgs e)
        {
            ChangePassForm changePassForm = new ChangePassForm(autUser);

            changePassForm.Show();
            this.Close();
        }

        private void teamsButton_Click(object sender, EventArgs e)
        {
            TeamsForm teamsForm = new TeamsForm(autUser);

            teamsForm.Show();
            this.Close();
        }

        private void tourneysButton_Click(object sender, EventArgs e)
        {
            TourneysForm tourneysForm = new TourneysForm(autUser);

            tourneysForm.Show();
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void diagramsButton_Click(object sender, EventArgs e)
        {
            DiagramForm diagramForm = new DiagramForm(autUser);

            diagramForm.Show();
            this.Close();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}