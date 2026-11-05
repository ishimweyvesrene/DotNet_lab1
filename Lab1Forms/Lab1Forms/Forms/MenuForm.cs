using System;
using System.Windows.Forms;

namespace Lab1Forms
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();

            // When the menu is closed (CLOSE button or the X), the whole project ends
            this.FormClosed += (s, e) => Application.Exit();
        }

        private void btnBicycle_Click(object sender, EventArgs e)
        {
            BicycleForm bicycle = new BicycleForm();

            // When the bicycle form is closed (EXIT button), come back to this menu
            bicycle.FormClosed += (s, args) => this.Show();

            this.Hide();
            bicycle.Show();
        }

        private void btnMushroom_Click(object sender, EventArgs e)
        {
            MushroomForm mushroom = new MushroomForm();

            // When the mushroom form is closed (EXIT button), come back to this menu
            mushroom.FormClosed += (s, args) => this.Show();

            this.Hide();
            mushroom.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
