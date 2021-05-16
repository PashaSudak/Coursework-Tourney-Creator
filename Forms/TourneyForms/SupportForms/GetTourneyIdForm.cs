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
using Tourney_Creator.Forms.TourneyForms;

namespace Tourney_Creator
{
    public partial class GetTourneyIdForm : Form
    {
        User autUser = new User();
        TourneysDB db = new TourneysDB();
        private int nextFormId;
        private Form nextForm = null;

        public GetTourneyIdForm(User autUser, int nextFormId)
        {
            InitializeComponent();

            this.autUser = autUser;
            this.nextFormId = nextFormId;

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

                    if (nextFormId == 1) nextForm = new UpdateTourneyForm(tourney, autUser);
                    else nextForm = new ShowTourney(tourney, autUser);

                    this.Close();
                    nextForm.Show();
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
