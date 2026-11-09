using System;
using System.Windows.Forms;

namespace LoginRegisterApp
{
    public partial class WelcomeForm : Form
    {
        public bool LoggedOut { get; private set; }

        public WelcomeForm(string userName)
        {
            InitializeComponent();
            lblWelcome.Text = "Welcome, " + userName;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoggedOut = true;
            Close();
        }
    }
}
