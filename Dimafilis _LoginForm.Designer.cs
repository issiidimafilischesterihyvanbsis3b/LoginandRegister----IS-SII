namespace LoginRegisterApp
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkShow = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblNoAccount = new System.Windows.Forms.Label();
            this.lnkRegister = new System.Windows.Forms.LinkLabel();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();

            // pnlHeader
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.pnlHeader.Size = new System.Drawing.Size(440, 130);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSub);

            // lblTitle
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.lblTitle.Location = new System.Drawing.Point(30, 28);
            this.lblTitle.Text = "Hello Again!";

            // lblSub
            this.lblSub.Name = "lblSub";
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(220, 252, 231);
            this.lblSub.Location = new System.Drawing.Point(34, 80);
            this.lblSub.Text = "Please login to continue";

            // lblUser
            this.lblUser.Name = "lblUser";
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblUser.Location = new System.Drawing.Point(32, 160);
            this.lblUser.Text = "Username";

            // txtUsername
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUsername.Location = new System.Drawing.Point(36, 184);
            this.txtUsername.Size = new System.Drawing.Size(368, 29);
            this.txtUsername.TabIndex = 0;

            // lblPass
            this.lblPass.Name = "lblPass";
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPass.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblPass.Location = new System.Drawing.Point(32, 235);
            this.lblPass.Text = "Password";

            // txtPassword
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPassword.Location = new System.Drawing.Point(36, 259);
            this.txtPassword.Size = new System.Drawing.Size(368, 29);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;

            // chkShow
            this.chkShow.Name = "chkShow";
            this.chkShow.AutoSize = true;
            this.chkShow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkShow.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.chkShow.Location = new System.Drawing.Point(36, 305);
            this.chkShow.TabIndex = 2;
            this.chkShow.Text = "Show password";
            this.chkShow.CheckedChanged += new System.EventHandler(this.chkShow_CheckedChanged);

            // btnLogin
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnLogin.Location = new System.Drawing.Point(36, 345);
            this.btnLogin.Size = new System.Drawing.Size(368, 48);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // lblNoAccount
            this.lblNoAccount.Name = "lblNoAccount";
            this.lblNoAccount.AutoSize = true;
            this.lblNoAccount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNoAccount.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblNoAccount.Location = new System.Drawing.Point(85, 415);
            this.lblNoAccount.Text = "Don't have an account?";

            // lnkRegister
            this.lnkRegister.Name = "lnkRegister";
            this.lnkRegister.AutoSize = true;
            this.lnkRegister.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lnkRegister.LinkColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.lnkRegister.Location = new System.Drawing.Point(247, 415);
            this.lnkRegister.TabIndex = 4;
            this.lnkRegister.TabStop = true;
            this.lnkRegister.Text = "Register";
            this.lnkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRegister_LinkClicked);

            // LoginForm
            this.AcceptButton = this.btnLogin;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(240, 253, 244);
            this.ClientSize = new System.Drawing.Size(440, 480);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Name = "LoginForm";
            this.Controls.Add(this.lnkRegister);
            this.Controls.Add(this.lblNoAccount);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.chkShow);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.pnlHeader);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkShow;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblNoAccount;
        private System.Windows.Forms.LinkLabel lnkRegister;
    }
}
