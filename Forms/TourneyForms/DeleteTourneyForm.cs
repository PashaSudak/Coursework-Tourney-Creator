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
    public partial class DeleteTourneyForm : Form
    {
        User autUser = new User();
        TourneysDB db = new TourneysDB();
        public DeleteTourneyForm(User autUser)
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

        private void textBoxTourneyId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void deleteTourneyButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxTourneyId.Text.Trim());

                int result = db.DeleteTourneyFromDB(id);

                if (result == 0)
                {
                    MessageBox.Show("Турнір не знайденно!",
                        "!!!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    File.AppendAllText("log.txt", "Errror. Tourney not found.\n");
                }
                else
                {
                    MessageBox.Show("Турнір видаленно!",
                        "!!!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    File.AppendAllText("log.txt", "Info. " + autUser.Login + " deleted tourney with id " + id + ".\n");
                }
            }
            catch
            {
                MessageBox.Show("ERROR: Пусте поле",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                File.AppendAllText("log.txt", "Errror. Empty textBox.\n");
            }
        }
    }
}
