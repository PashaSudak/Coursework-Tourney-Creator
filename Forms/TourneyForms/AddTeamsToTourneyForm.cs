using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Tourney_Creator
{
    public partial class AddTeamsToTourneyForm : Form
    {
        User autUser = new User();
        private string tourneyName = "-1";
        private string jsonTeamsId = "";
        List<int> teamsIdList = new List<int>();
        TeamsDB teamsDB = new TeamsDB();
        TourneysDB tourneysDb = new TourneysDB();
        public AddTeamsToTourneyForm(User autUser, string tourneyName)
        {
            InitializeComponent();

            this.autUser = autUser;

            this.tourneyName = tourneyName;

            teamsDB.ConnectToSQLiteDB();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            if (jsonTeamsId != "")
            {
                TourneysForm tourneysForm = new TourneysForm(autUser, tourneyName,jsonTeamsId);
                tourneysForm.Show();

                File.AppendAllText("log.txt", "Info. " + autUser.Login + " added new tourney: " + tourneyName + ".\n");
            }
            else
            {
                TourneysForm tourneysForm = new TourneysForm(autUser);
                tourneysForm.Show();
            }
            this.Close();
        }

        private void ShowTeamsButton_Click(object sender, EventArgs e)
        {
            TeamsForm teamsForm = new TeamsForm(autUser, true,this);

            this.Hide();
            teamsForm.Show();
        }

        private void addTeamButton_Click(object sender, EventArgs e)
        {
            int newTeamId = Convert.ToInt32(textBoxTeamId.Text.Trim());

            if (teamsIdList.Contains(newTeamId))
            {
                MessageBox.Show("Команду з id " + newTeamId + " вже було доданно!",
                    "!!!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else if (teamsDB.isExist(newTeamId))
            {
                if (JsonConvert.DeserializeObject<List<int>>(jsonTeamsId) != null)
                {
                    teamsIdList = JsonConvert.DeserializeObject<List<int>>(jsonTeamsId);
                }

                teamsIdList.Add(newTeamId);

                jsonTeamsId = JsonConvert.SerializeObject(teamsIdList);

                MessageBox.Show("Команду з id " + newTeamId + " доданно!",
                    "!!!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show("Команду з id " + newTeamId + " не знайденно!",
                    "!!!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
