namespace Feedbuf
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.LogoutBttn = new System.Windows.Forms.Button();
            this.LogoPicBx = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicBx)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoutBttn
            // 
            this.LogoutBttn.Location = new System.Drawing.Point(670, 26);
            this.LogoutBttn.Name = "LogoutBttn";
            this.LogoutBttn.Size = new System.Drawing.Size(101, 36);
            this.LogoutBttn.TabIndex = 0;
            this.LogoutBttn.Text = "Log out";
            this.LogoutBttn.UseVisualStyleBackColor = true;
            this.LogoutBttn.Click += new System.EventHandler(this.LogoutBttn_Click);
            // 
            // LogoPicBx
            // 
            this.LogoPicBx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogoPicBx.BackgroundImage")));
            this.LogoPicBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogoPicBx.Location = new System.Drawing.Point(12, 12);
            this.LogoPicBx.Name = "LogoPicBx";
            this.LogoPicBx.Size = new System.Drawing.Size(121, 115);
            this.LogoPicBx.TabIndex = 1;
            this.LogoPicBx.TabStop = false;
            this.LogoPicBx.Click += new System.EventHandler(this.LogoPicBx_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogoPicBx);
            this.Controls.Add(this.LogoutBttn);
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicBx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button LogoutBttn;
        private PictureBox LogoPicBx;
    }
}