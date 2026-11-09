using System;
using System.Windows.Forms;

namespace LoginRegisterApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                Database.Init();   // creates the Access database + Users table on first run
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error:\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            while (true)
            {
                using (var login = new LoginForm())
                {
                    if (login.ShowDialog() != DialogResult.OK) break;   // closed login -> exit

                    using (var welcome = new WelcomeForm(login.UserName))
                    {
                        welcome.ShowDialog();
                        if (!welcome.LoggedOut) break;   // closed with X -> exit; Logout -> back to login
                    }
                }
            }
        }
    }
}
