﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tourney_Creator
{
    public partial class TeamsForm : Form
    {
        User autUser = new User();
        TeamsDB db = new TeamsDB();
        SQLiteCommandBuilder sqlBuilder = null;
        DataTable dataTable = null;
        public TeamsForm(User autUser)
        {
            InitializeComponent();

            this.autUser = autUser;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(autUser);

            this.Close();
            mainForm.Show();
        }

        private void TeamsForm_Load(object sender, EventArgs e)
        {
            db.ConnectToSQLiteDB();

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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void addTeamButton_Click(object sender, EventArgs e)
        {
            AddNewTeamForm teamForm = new AddNewTeamForm(autUser);

            this.Close();
            teamForm.Show();
        }

        private void deleteTeamButton_Click(object sender, EventArgs e)
        {
            DeleteTeamForm deleteTeamForm = new DeleteTeamForm(autUser);

            this.Close();
            deleteTeamForm.Show();
        }
    }
}