namespace Feedbuf
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserTxtBx = new System.Windows.Forms.TextBox();
            this.PasswordTxtBx = new System.Windows.Forms.TextBox();
            this.LoginBttn = new System.Windows.Forms.Button();
            this.UserLbl = new System.Windows.Forms.Label();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.RegisterBttn = new System.Windows.Forms.Button();
            this.RegisterLbl = new System.Windows.Forms.Label();
            this.info1Lbl = new System.Windows.Forms.Label();
            this.infoLbl = new System.Windows.Forms.Label();
            this.CreditLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserTxtBx
            // 
            this.UserTxtBx.Location = new System.Drawing.Point(285, 209);
            this.UserTxtBx.Name = "UserTxtBx";
            this.UserTxtBx.Size = new System.Drawing.Size(169, 27);
            this.UserTxtBx.TabIndex = 0;
            this.UserTxtBx.TextChanged += new System.EventHandler(this.UserTxtBx_TextChanged);
            // 
            // PasswordTxtBx
            // 
            this.PasswordTxtBx.Location = new System.Drawing.Point(285, 296);
            this.PasswordTxtBx.Name = "PasswordTxtBx";
            this.PasswordTxtBx.Size = new System.Drawing.Size(169, 27);
            this.PasswordTxtBx.TabIndex = 1;
            this.PasswordTxtBx.TextChanged += new System.EventHandler(this.PasswordTxtBx_TextChanged);
            // 
            // LoginBttn
            // 
            this.LoginBttn.Location = new System.Drawing.Point(312, 342);
            this.LoginBttn.Name = "LoginBttn";
            this.LoginBttn.Size = new System.Drawing.Size(112, 43);
            this.LoginBttn.TabIndex = 2;
            this.LoginBttn.Text = "Log in";
            this.LoginBttn.UseVisualStyleBackColor = true;
            this.LoginBttn.Click += new System.EventHandler(this.LoginBttn_Click);
            // 
            // UserLbl
            // 
            this.UserLbl.AutoSize = true;
            this.UserLbl.Location = new System.Drawing.Point(339, 171);
            this.UserLbl.Name = "UserLbl";
            this.UserLbl.Size = new System.Drawing.Size(75, 20);
            this.UserLbl.TabIndex = 3;
            this.UserLbl.Text = "Username";
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Location = new System.Drawing.Point(339, 261);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(70, 20);
            this.PasswordLbl.TabIndex = 4;
            this.PasswordLbl.Text = "Password";
            // 
            // RegisterBttn
            // 
            this.RegisterBttn.Location = new System.Drawing.Point(636, 357);
            this.RegisterBttn.Name = "RegisterBttn";
            this.RegisterBttn.Size = new System.Drawing.Size(98, 48);
            this.RegisterBttn.TabIndex = 5;
            this.RegisterBttn.Text = "Register";
            this.RegisterBttn.UseVisualStyleBackColor = true;
            this.RegisterBttn.Click += new System.EventHandler(this.RegisterBttn_Click);
            // 
            // RegisterLbl
            // 
            this.RegisterLbl.AutoSize = true;
            this.RegisterLbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegisterLbl.Location = new System.Drawing.Point(626, 329);
            this.RegisterLbl.Name = "RegisterLbl";
            this.RegisterLbl.Size = new System.Drawing.Size(118, 25);
            this.RegisterLbl.TabIndex = 6;
            this.RegisterLbl.Text = "No account?";
            // 
            // info1Lbl
            // 
            this.info1Lbl.AutoSize = true;
            this.info1Lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.info1Lbl.Location = new System.Drawing.Point(248, 85);
            this.info1Lbl.Name = "info1Lbl";
            this.info1Lbl.Size = new System.Drawing.Size(253, 28);
            this.info1Lbl.TabIndex = 7;
            this.info1Lbl.Text = "Welcome to the application";
            // 
            // infoLbl
            // 
            this.infoLbl.AutoSize = true;
            this.infoLbl.Location = new System.Drawing.Point(331, 133);
            this.infoLbl.Name = "infoLbl";
            this.infoLbl.Size = new System.Drawing.Size(93, 20);
            this.infoLbl.TabIndex = 8;
            this.infoLbl.Text = "Please log in";
            // 
            // CreditLbl
            // 
            this.CreditLbl.AutoSize = true;
            this.CreditLbl.Location = new System.Drawing.Point(12, 424);
            this.CreditLbl.Name = "CreditLbl";
            this.CreditLbl.Size = new System.Drawing.Size(193, 20);
            this.CreditLbl.TabIndex = 9;
            this.CreditLbl.Text = "Made by Bende van Ellende";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(832, 453);
            this.Controls.Add(this.CreditLbl);
            this.Controls.Add(this.infoLbl);
            this.Controls.Add(this.info1Lbl);
            this.Controls.Add(this.RegisterLbl);
            this.Controls.Add(this.RegisterBttn);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.UserLbl);
            this.Controls.Add(this.LoginBttn);
            this.Controls.Add(this.PasswordTxtBx);
            this.Controls.Add(this.UserTxtBx);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox UserTxtBx;
        private TextBox PasswordTxtBx;
        private Button LoginBttn;
        private Label UserLbl;
        private Label PasswordLbl;
        private Button RegisterBttn;
        private Label RegisterLbl;
        private Label info1Lbl;
        private Label infoLbl;
        private Label CreditLbl;
    }
}