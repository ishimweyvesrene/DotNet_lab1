using System;
using System.Windows.Forms;

namespace Lab1Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // Validation: username and password must not be empty (no database used)
        private bool FieldsAreValid()
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show("Username cannot be empty.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Password cannot be empty.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }

            return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!FieldsAreValid())
                return;

            // Login accepted: open the menu form and hide the login form
            MenuForm menu = new MenuForm();
            menu.Show();
            this.Hide();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if (!FieldsAreValid())
                return;

            // Shows what was typed (the password is masked)
            string hidden = new string('*', txtPassword.Text.Length);
            MessageBox.Show("Username: " + txtUserName.Text.Trim() + "\nPassword: " + hidden,
                "Entered details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
