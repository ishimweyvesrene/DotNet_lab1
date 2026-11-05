using System;
using System.Windows.Forms;

namespace Lab1Forms
{
    public partial class MushroomForm : Form
    {
        public MushroomForm()
        {
            InitializeComponent();
        }

        // Shows a Yes/No message and returns true if the user clicks Yes
        private bool Ask(string question)
        {
            DialogResult answer = MessageBox.Show(question, "Mushroom question",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            return answer == DialogResult.Yes;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            string mushroom;

            // At most 3 questions are asked
            if (Ask("Does your mushroom have a ring?"))
            {
                if (Ask("Does your mushroom grow in a forest?"))
                    mushroom = "Amanite tue-mouche";
                else if (Ask("Does your mushroom have a convex cup?"))
                    mushroom = "Agaric jaunissant";
                else
                    mushroom = "Coprin chevelu";
            }
            else
            {
                if (Ask("Does your mushroom have a convex cup?"))
                    mushroom = "Pied bleu";
                else if (Ask("Does your mushroom have gills?"))
                    mushroom = "Girolle";
                else
                    mushroom = "Cepe de bordeaux";
            }

            lblResult.Text = "Your mushroom is: " + mushroom;

            MessageBox.Show("Your mushroom is: " + mushroom, "Result",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Closing this form brings the menu form back
            this.Close();
        }
    }
}
