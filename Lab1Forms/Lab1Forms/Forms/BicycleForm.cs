using System;
using System.Windows.Forms;

namespace Lab1Forms
{
    public partial class BicycleForm : Form
    {
        public BicycleForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";

            // Only whole numbers are accepted (no decimals)
            bool startOk = int.TryParse(txtStart.Text, out int start);
            bool endOk = int.TryParse(txtEnd.Text, out int end);

            if (!startOk || !endOk)
            {
                MessageBox.Show("Please enter whole numbers only (decimals are not accepted).",
                    "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (start < 0 || start > 23)
            {
                MessageBox.Show("The starting hour must be between 0 and 23.",
                    "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (end < 1 || end > 24)
            {
                MessageBox.Show("The ending hour must be between 1 and 24.",
                    "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (start >= end)
            {
                MessageBox.Show("The starting hour must be less than the ending hour.",
                    "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int total = 0;

            // Add the rate of each rented hour
            for (int hour = start; hour < end; hour++)
            {
                if (hour < 7)
                    total += 500;       // 0 - 7
                else if (hour < 14)
                    total += 1000;      // 7 - 14
                else if (hour < 19)
                    total += 1500;      // 14 - 19
                else if (hour < 21)
                    total += 1000;      // 19 - 21
                else
                    total += 500;       // 21 - 24
            }

            lblResult.Text = "Total to pay: " + total + " RWF";

            MessageBox.Show("Rental from " + start + "h to " + end + "h (" + (end - start) + " hour(s))\n" +
                            "Total to pay: " + total + " RWF",
                "Rental price", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Closing this form brings the menu form back
            this.Close();
        }
    }
}
