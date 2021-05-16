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
    public partial class UpdateTourneyForm : Form
    {
        Tourney tourney = new Tourney();
        User autUser = new User();
        TourneysDB tourneysDb = new TourneysDB();
        TeamsDB teamsDb = new TeamsDB();
        List<int> lst;
        List<int> newLst;
        List<int> lastRoundList = new List<int>();
        int currentMatch = 0;

        public UpdateTourneyForm(Tourney tourney, User autUser)
        {
            InitializeComponent();

            this.tourney = tourney;
            this.autUser = autUser;

            teamsDb.ConnectToSQLiteDB();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            TourneysForm tourneysForm = new TourneysForm(autUser);

            this.Close();
            tourneysForm.Show();
        }

        private void updateWinner()
        {
            List<int> tempLst = new List<int>();

            //find how much teams in tourney
            int i;
            for (i = 0; i < lst.Count; i++)
            {
                if (tempLst.Contains(lst[i]))
                {
                    break;
                }
                tempLst.Add(lst[i]);
            }

            int teamsCount = i;

            //find where standing teams starts
            tempLst.Clear();
            int lastRoundStart = 0;
            for (i = 0; i < lst.Count; i++)
            {
                if (tempLst.Contains(lst[i]))
                {
                    lastRoundStart = i;
                    tempLst.Clear();
                }
                tempLst.Add(lst[i]);
            }

            //creating last round list
            for (i = lastRoundStart; i < lst.Count; i++)
            {
                lastRoundList.Add(lst[i]);
            }

            currentMatch = 0;
            team1Button.Text = Convert.ToString(teamsDb.GetTeamName(lastRoundList[currentMatch]));
            //if tourney contains only 1 team
            try
            {
                team2Button.Text = Convert.ToString(teamsDb.GetTeamName(lastRoundList[currentMatch + 1]));
            }
            catch
            {
                MessageBox.Show("Турнір вже закінчен!",
                    "INFO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                TourneysForm tourneysForm = new TourneysForm(autUser);

                this.Close();
                tourneysForm.Show();
            }
        }

        private void UpdateTourneyForm_Load(object sender, EventArgs e)
        {
            lst = tourney.getTeamsIdList();
            newLst = new List<int>();

            for (int i = 0; i < lst.Count; i++)
            {
                newLst.Add(lst[i]);
            }

            updateWinner();
        }

        private void updateButtons()
        {
            try
            {
                currentMatch += 2;

                team1Button.Text = Convert.ToString(teamsDb.GetTeamName(lastRoundList[currentMatch]));
                team2Button.Text = Convert.ToString(teamsDb.GetTeamName(lastRoundList[currentMatch + 1]));
            }
            catch
            {
                try
                {
                    newLst.Add(lastRoundList[currentMatch]);
                }
                catch { }

                this.Hide();

                MessageBox.Show("Раунд закінчен!",
                    "INFO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);


                TourneysForm tourneysForm = new TourneysForm(autUser, tourney.Id, newLst);
                tourneysForm.Show();
            }
        }

        private void team1Button_Click(object sender, EventArgs e)
        {
            newLst.Add(lastRoundList[currentMatch]);
            teamsDb.addWinLose(lastRoundList[currentMatch], true);
            teamsDb.addWinLose(lastRoundList[currentMatch + 1], false);
            updateButtons();
        }

        private void team2Button_Click(object sender, EventArgs e)
        {
            newLst.Add(lastRoundList[currentMatch + 1]);
            teamsDb.addWinLose(lastRoundList[currentMatch + 1], true);
            teamsDb.addWinLose(lastRoundList[currentMatch], false);
            updateButtons();
        }
    }
}
