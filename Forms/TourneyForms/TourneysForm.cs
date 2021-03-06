﻿using System;
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

        public TourneysForm(User autUser, int tourneyId, List<int> teamsList)
        {
            InitializeComponent();

            this.autUser = autUser;

            db.ConnectToSQLiteDB();
            db.updateTeamsId(tourneyId, teamsList);
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

            dataGridView1.Columns[1].HeaderText = "Назва турніру";
            dataGridView1.Columns[2].HeaderText = "Турнірна сітка";
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

        private void updateTourneyButton_Click(object sender, EventArgs e)
        {
            GetTourneyIdForm getTourneyIdForm = new GetTourneyIdForm(autUser, 1);

            this.Close();
            getTourneyIdForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetTourneyIdForm getTourneyIdForm = new GetTourneyIdForm(autUser, 2);

            this.Close();
            getTourneyIdForm.Show();
        }
    }
}
