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
            this.Hide();
        }

        private void teamsButton_Click(object sender, EventArgs e)
        {
            TeamsForm teamsForm = new TeamsForm(autUser);

            teamsForm.Show();
            this.Hide();
        }

        private void tourneysButton_Click(object sender, EventArgs e)
        {
            TourneysForm tourneysForm = new TourneysForm(autUser);

            tourneysForm.Show();
            this.Hide();
        }
    }
}