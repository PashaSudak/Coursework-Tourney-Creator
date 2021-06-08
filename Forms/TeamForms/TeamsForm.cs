using System;
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
        private bool watchOnly = false;
        private AddTeamsToTourneyForm addTeamsToTourneyForm;
        public TeamsForm(User autUser)
        {
            InitializeComponent();

            this.autUser = autUser;
        }

        public TeamsForm(User autUser, bool watchOnly, AddTeamsToTourneyForm form)
        {
            InitializeComponent();

            this.autUser = autUser;

            this.watchOnly = watchOnly;

            this.addTeamsToTourneyForm = form;

            closeButton.Text = "Назад";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            if (watchOnly)
            {
                addTeamsToTourneyForm.Show();
            }
            else
            {
                MainForm mainForm = new MainForm(autUser);
                mainForm.Show();
            }

            this.Close();
        }

        private void TeamsForm_Load(object sender, EventArgs e)
        {
            db.ConnectToSQLiteDB();

            LoadData();

            dataGridView1.Columns[1].HeaderText = "Назва команди";
            dataGridView1.Columns[2].HeaderText = "К-сть перемог";
            dataGridView1.Columns[3].HeaderText = "К-сть поразок";
            dataGridView1.Columns[4].HeaderText = "Відсоток перемог (%)";
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
