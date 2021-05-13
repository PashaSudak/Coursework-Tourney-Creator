using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace Tourney_Creator
{
    public partial class TourneysForm : Form
    {
        private User autUser;
        TourneysDB db = new TourneysDB();
        private DataTable dataTable = null;
        public TourneysForm(User autUser)
        {
            InitializeComponent();

            this.autUser = autUser;

            db.ConnectToSQLiteDB();
        }

        public TourneysForm(User autUser, string tourneyName, string jsonIds)
        {
            InitializeComponent();

            this.autUser = autUser;

            db.ConnectToSQLiteDB();
            db.AddNewTourney(tourneyName,jsonIds);
        }

        private void addNewTourney_Click(object sender, EventArgs e)
        {
            TourneySetName tourneySetName = new TourneySetName(autUser);

            this.Close();
            tourneySetName.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(autUser);
            
            this.Close();
            mainForm.Show();
        }

        private void TourneysForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dataTable = db.GetDataTable();

                dataGridView1.DataSource = dataTable;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show("ERROR",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void deleteTourneyButton_Click(object sender, EventArgs e)
        {
            DeleteTourneyForm deleteTourneyForm = new DeleteTourneyForm(autUser);

            this.Close();
            deleteTourneyForm.Show();
        }
    }
}
