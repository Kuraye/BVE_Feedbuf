namespace Feedbuf
{
    partial class ForgotPassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ReturnBttn = new Button();
            FP_txbStudentNumber = new TextBox();
            FP_txbPassword1 = new TextBox();
            FP_txbPassword2 = new TextBox();
            Btn_EditPassword = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // ReturnBttn
            // 
            ReturnBttn.Location = new Point(12, 12);
            ReturnBttn.Name = "ReturnBttn";
            ReturnBttn.Size = new Size(126, 47);
            ReturnBttn.TabIndex = 1;
            ReturnBttn.Text = "Return";
            ReturnBttn.UseVisualStyleBackColor = true;
            ReturnBttn.Click += ReturnBttn_Click;
            // 
            // FP_txbStudentNumber
            // 
            FP_txbStudentNumber.Location = new Point(331, 144);
            FP_txbStudentNumber.Name = "FP_txbStudentNumber";
            FP_txbStudentNumber.PlaceholderText = "StudentNumber";
            FP_txbStudentNumber.Size = new Size(125, 27);
            FP_txbStudentNumber.TabIndex = 2;
            // 
            // FP_txbPassword1
            // 
            FP_txbPassword1.Location = new Point(331, 195);
            FP_txbPassword1.Name = "FP_txbPassword1";
            FP_txbPassword1.PasswordChar = '*';
            FP_txbPassword1.PlaceholderText = "New Password";
            FP_txbPassword1.Size = new Size(125, 27);
            FP_txbPassword1.TabIndex = 3;
            // 
            // FP_txbPassword2
            // 
            FP_txbPassword2.Location = new Point(331, 250);
            FP_txbPassword2.Name = "FP_txbPassword2";
            FP_txbPassword2.PasswordChar = '*';
            FP_txbPassword2.PlaceholderText = "Repeat Password";
            FP_txbPassword2.Size = new Size(125, 27);
            FP_txbPassword2.TabIndex = 4;
            // 
            // Btn_EditPassword
            // 
            Btn_EditPassword.Location = new Point(338, 305);
            Btn_EditPassword.Name = "Btn_EditPassword";
            Btn_EditPassword.Size = new Size(110, 29);
            Btn_EditPassword.TabIndex = 5;
            Btn_EditPassword.Text = "Edit Password";
            Btn_EditPassword.UseVisualStyleBackColor = true;
            Btn_EditPassword.Click += Btn_EditPassword_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(310, 80);
            label1.Name = "label1";
            label1.Size = new Size(175, 28);
            label1.TabIndex = 6;
            label1.Text = "Edit Password here";
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Btn_EditPassword);
            Controls.Add(FP_txbPassword2);
            Controls.Add(FP_txbPassword1);
            Controls.Add(FP_txbStudentNumber);
            Controls.Add(ReturnBttn);
            Name = "ForgotPassword";
            Text = "ForgotPassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ReturnBttn;
        private TextBox FP_txbStudentNumber;
        private TextBox FP_txbPassword1;
        private TextBox FP_txbPassword2;
        private Button Btn_EditPassword;
        private Label label1;
    }
}