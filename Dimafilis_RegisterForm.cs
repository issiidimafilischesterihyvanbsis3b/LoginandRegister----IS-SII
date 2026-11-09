using System;
using System.Windows.Forms;

namespace LoginRegisterApp
{
    public partial class RegisterForm : Form
    {
        public string RegisteredUser { get; private set; }

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string full = txtFullName.Text.Trim();
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text;
            string conf = txtConfirm.Text;

            if (full == "" || user == "" || pass == "" || conf == "")
            { Warn("Please fill in all fields."); return; }

            if (pass.Length < 6)
            { Warn("Password must be at least 6 characters."); return; }

            if (pass != conf)
            { Warn("Passwords do not match."); return; }

            try
            {
                if (Database.UserExists(user))
                { Warn("That username is already taken."); return; }

                Database.Register(full, user, "", pass);
                MessageBox.Show("Account created! You can now log in.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                RegisteredUser = user;
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private static void Warn(string msg)
        {
            MessageBox.Show(msg, "Register", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
