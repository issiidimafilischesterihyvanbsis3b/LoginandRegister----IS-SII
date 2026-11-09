namespace LoginRegisterApp
{
    partial class RegisterForm
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
            this.lblFull = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lnkBack = new System.Windows.Forms.LinkLabel();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();

            // pnlHeader
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.pnlHeader.Size = new System.Drawing.Size(440, 100);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSub);

            // lblTitle
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.lblTitle.Location = new System.Drawing.Point(28, 14);
            this.lblTitle.Text = "Create Account";

            // lblSub
            this.lblSub.Name = "lblSub";
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(220, 252, 231);
            this.lblSub.Location = new System.Drawing.Point(32, 62);
            this.lblSub.Text = "Fill in the details to register";

            // lblFull
            this.lblFull.Name = "lblFull";
            this.lblFull.AutoSize = true;
            this.lblFull.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFull.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblFull.Location = new System.Drawing.Point(32, 118);
            this.lblFull.Text = "Full Name";

            // txtFullName
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFullName.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.txtFullName.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtFullName.Location = new System.Drawing.Point(36, 142);
            this.txtFullName.Size = new System.Drawing.Size(368, 29);
            this.txtFullName.TabIndex = 0;

            // lblUser
            this.lblUser.Name = "lblUser";
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblUser.Location = new System.Drawing.Point(32, 182);
            this.lblUser.Text = "Username";

            // txtUsername
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUsername.Location = new System.Drawing.Point(36, 206);
            this.txtUsername.Size = new System.Drawing.Size(368, 29);
            this.txtUsername.TabIndex = 1;

            // lblPass
            this.lblPass.Name = "lblPass";
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPass.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblPass.Location = new System.Drawing.Point(32, 246);
            this.lblPass.Text = "Password";

            // txtPassword
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPassword.Location = new System.Drawing.Point(36, 270);
            this.txtPassword.Size = new System.Drawing.Size(368, 29);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;

            // lblConfirm
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblConfirm.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblConfirm.Location = new System.Drawing.Point(32, 310);
            this.lblConfirm.Text = "Confirm Password";

            // txtConfirm
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirm.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.txtConfirm.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.txtConfirm.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtConfirm.Location = new System.Drawing.Point(36, 334);
            this.txtConfirm.Size = new System.Drawing.Size(368, 29);
            this.txtConfirm.TabIndex = 3;
            this.txtConfirm.UseSystemPasswordChar = true;

            // btnRegister
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRegister.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnRegister.Location = new System.Drawing.Point(36, 382);
            this.btnRegister.Size = new System.Drawing.Size(368, 45);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

            // lnkBack
            this.lnkBack.Name = "lnkBack";
            this.lnkBack.AutoSize = true;
            this.lnkBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lnkBack.LinkColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.lnkBack.Location = new System.Drawing.Point(140, 440);
            this.lnkBack.TabIndex = 5;
            this.lnkBack.TabStop = true;
            this.lnkBack.Text = "Back to Login";
            this.lnkBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkBack_LinkClicked);

            // RegisterForm
            this.AcceptButton = this.btnRegister;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(240, 253, 244);
            this.ClientSize = new System.Drawing.Size(440, 480);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Register";
            this.Name = "RegisterForm";
            this.Controls.Add(this.lnkBack);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblFull);
            this.Controls.Add(this.pnlHeader);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblFull;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.LinkLabel lnkBack;
    }
}
