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

namespace Tourney_Creator
{
    public partial class GetTourneyIdForm : Form
    {
        User autUser = new User();
        TourneysDB db = new TourneysDB();
        public GetTourneyIdForm(User autUser)
        {
            InitializeComponent();

            this.autUser = autUser;

            db.ConnectToSQLiteDB();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            TourneysForm tourneysForm = new TourneysForm(autUser);

            this.Close();
            tourneysForm.Show();
        }

        private void textBoxTourneyName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxTourneyName.Text.Trim());

                Tourney tourney = db.GetTourney(id);

                if (tourney.Name == "")
                {
                    MessageBox.Show("ERROR: Такого турніра не існує в бд",
                        "ERROR",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    UpdateTourneyForm updateTourneyForm = new UpdateTourneyForm(tourney, autUser);

                    this.Close();
                    updateTourneyForm.Show();
                }
            }
            catch
            {
                MessageBox.Show("ERROR: Пусте поле",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void GetTourneyIdForm_Load(object sender, EventArgs e)
        {

        }
    }
}
