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
            int id = Convert.ToInt32(textBoxTourneyId.Text.Trim());

            int result = db.DeleteTourneyFromDB(id);

            if (result == 0)
            {
                MessageBox.Show("Команду не знайденно!",
                    "!!!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            else
            {
                MessageBox.Show("Команду видаленно!",
                    "!!!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                File.AppendAllText("log.txt", "Info. " + autUser.Login + " deleted tourney with id " + id + ".\n");
            }
        }
    }
}
