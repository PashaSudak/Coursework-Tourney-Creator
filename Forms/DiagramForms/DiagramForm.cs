using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tourney_Creator.Forms.DiagramForms
{
    public partial class DiagramForm : Form
    {
        private User autUser;
        TeamsDB teamsDb = new TeamsDB();
        public DiagramForm(User autUser)
        {
            InitializeComponent();

            this.autUser = autUser;

            teamsDb.ConnectToSQLiteDB();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(autUser);

            this.Close();
            mainForm.Show();
        }

        private void DiagramForm_Load(object sender, EventArgs e)
        {
            chart1.Series[0].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;

            DataTable dataTable = teamsDb.GetDataTable();

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow row = dataTable.Rows[i];
                if (Convert.ToInt32(row["wins"]) > 0)
                {
                    chart1.Series[0].Points.AddXY(row[1], Convert.ToDouble(row[2]));
                }
            }

            chart2.Series[0].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow row = dataTable.Rows[i];
                if (Convert.ToInt32(row["loses"]) > 0)
                {
                    chart2.Series[0].Points.AddXY(row[1], Convert.ToDouble(row[3]));
                }
            }

            chart1.Series[0]["PieLabelStyle"] = "Disabled";
            chart2.Series[0]["PieLabelStyle"] = "Disabled";
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
    }
}
