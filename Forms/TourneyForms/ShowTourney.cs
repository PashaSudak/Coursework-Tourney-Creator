using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Tourney_Creator.Forms.TourneyForms
{
    public partial class ShowTourney : Form
    {
        User autUser;
        private Tourney tourney;
        TeamsDB teamsDb = new TeamsDB();
        public ShowTourney(Tourney tourney, User autUser)
        {
            InitializeComponent();

            this.autUser = autUser;
            this.tourney = tourney;

            teamsDb.ConnectToSQLiteDB();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TourneysForm tourneysForm = new TourneysForm(autUser);

            this.Close();
            tourneysForm.Show();
        }

        private void ShowTourney_Load(object sender, EventArgs e)
        {
            List<int> list = JsonConvert.DeserializeObject<List<int>>(tourney.TeamsId);
            List<int> lastRoundList = new List<int>();

            int round = 1;
            string text = "1 раунд:\n";
            int even = 1;

            lastRoundList.Add(list[0]);

            //even потрібен для випадків з непарной кількістю команд
            for (int i = 1; i < list.Count; i++)
            {
                if (lastRoundList.Contains(list[i]))
                {
                    if (i % 2 == even)
                    {
                        text += ("Команда " + teamsDb.GetTeamName(list[i - 1]) + " проходить в наступний раунд\n");

                        if (even == 0) even = 1;
                        else even = 0;
                    }

                    if (i != list.Count - 1)
                    {
                        round++;
                        text += ("\n" + round + " раунд:\n");
                    }
                    lastRoundList.Clear();
                }

                lastRoundList.Add(list[i]);

                if (i == list.Count - 1 && lastRoundList.Count > 1 && lastRoundList.Count % 2 != 0)
                {
                    text += ("Команда " + teamsDb.GetTeamName(list[i]) + " проходить в наступний раунд\n");
                }

                

                if (i % 2 == even)
                {
                    text += (teamsDb.GetTeamName(list[i - 1]) + "    -    " + teamsDb.GetTeamName(list[i]) + "\n");
                }
            }

            if (lastRoundList.Count == 1)
            {
                text += ("\n\nПереможець - " + teamsDb.GetTeamName(list[list.Count - 1]));
            }

            label1.Text = text;

            this.Text = "Турнір " + tourney.Name;
        }
    }
}
