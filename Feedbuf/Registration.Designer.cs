namespace Feedbuf
{
    partial class Registration
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
            RegisterBttn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // ReturnBttn
            // 
            ReturnBttn.Location = new Point(21, 17);
            ReturnBttn.Name = "ReturnBttn";
            ReturnBttn.Size = new Size(126, 47);
            ReturnBttn.TabIndex = 0;
            ReturnBttn.Text = "Return";
            ReturnBttn.UseVisualStyleBackColor = true;
            ReturnBttn.Click += ReturnBttn_Click;
            // 
            // RegisterBttn
            // 
            RegisterBttn.Location = new Point(318, 342);
            RegisterBttn.Name = "RegisterBttn";
            RegisterBttn.Size = new Size(179, 61);
            RegisterBttn.TabIndex = 1;
            RegisterBttn.Text = "Register account";
            RegisterBttn.UseVisualStyleBackColor = true;
            RegisterBttn.Click += RegisterBttn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(363, 107);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(363, 181);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(341, 251);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 4;
            label3.Text = "Repeat Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(318, 139);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "StudentNumber";
            textBox1.Size = new Size(176, 27);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(317, 204);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.PlaceholderText = "Password";
            textBox2.Size = new Size(176, 27);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(317, 284);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.PlaceholderText = "Repeat Password";
            textBox3.Size = new Size(176, 27);
            textBox3.TabIndex = 7;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(235, 50);
            label4.Name = "label4";
            label4.Size = new Size(345, 25);
            label4.TabIndex = 8;
            label4.Text = "Please fill in the following fields to register";
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 483);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(RegisterBttn);
            Controls.Add(ReturnBttn);
            Name = "Registration";
            Text = "Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ReturnBttn;
        private Button RegisterBttn;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label4;
    }
}