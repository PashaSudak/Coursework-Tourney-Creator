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
    public partial class TourneySetName : Form
    {
        private User autUser = new User();
        public TourneySetName(User autUser)
        {
            InitializeComponent();

            this.autUser = autUser;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            TourneysForm tourneysForm = new TourneysForm(autUser);

            this.Close();
            tourneysForm.Show();
        }

        private void deleteTeamButton_Click(object sender, EventArgs e)
        {
            string name = textBoxTourneyName.Text.Trim();

            AddTeamsToTourneyForm addTeamsToTourneyForm = new AddTeamsToTourneyForm(autUser, name);

            this.Close();
            addTeamsToTourneyForm.Show();
        }

        private void textBoxTourneyName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
