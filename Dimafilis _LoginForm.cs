using System;
using System.Windows.Forms;

namespace LoginRegisterApp
{
    public partial class LoginForm : Form
    {
        public string FullName { get; private set; }
        public string UserName { get; private set; }
        public string Email { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text;

            if (user == "" || pass == "")
            {
                MessageBox.Show("Please enter username and password.", "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                UserInfo info = Database.Login(user, pass);
                if (info == null)
                {
                    MessageBox.Show("Invalid username or password.", "Login failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    txtPassword.Focus();
                    return;
                }
                FullName = info.FullName;
                UserName = info.UserName;
                Email = info.Email;
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var reg = new RegisterForm())
            {
                if (reg.ShowDialog() == DialogResult.OK)
                {
                    txtUsername.Text = reg.RegisteredUser;
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShow.Checked;
        }
    }
}
