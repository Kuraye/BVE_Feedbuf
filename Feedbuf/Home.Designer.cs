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
            this.HomeBttn = new System.Windows.Forms.Button();
            this.GoalsBttn = new System.Windows.Forms.Button();
            this.AskFeedbackBttn = new System.Windows.Forms.Button();
            this.LogoPicBx = new System.Windows.Forms.PictureBox();
            this.FeedbackLogBttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicBx)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoutBttn
            // 
            this.LogoutBttn.Location = new System.Drawing.Point(693, 26);
            this.LogoutBttn.Name = "LogoutBttn";
            this.LogoutBttn.Size = new System.Drawing.Size(95, 31);
            this.LogoutBttn.TabIndex = 0;
            this.LogoutBttn.Text = "Log out";
            this.LogoutBttn.UseVisualStyleBackColor = true;
            this.LogoutBttn.Click += new System.EventHandler(this.LogoutBttn_Click);
            // 
            // HomeBttn
            // 
            this.HomeBttn.Location = new System.Drawing.Point(139, 26);
            this.HomeBttn.Name = "HomeBttn";
            this.HomeBttn.Size = new System.Drawing.Size(121, 68);
            this.HomeBttn.TabIndex = 2;
            this.HomeBttn.Text = "Home";
            this.HomeBttn.UseVisualStyleBackColor = true;
            this.HomeBttn.Click += new System.EventHandler(this.HomeBttn_Click);
            // 
            // GoalsBttn
            // 
            this.GoalsBttn.Location = new System.Drawing.Point(266, 26);
            this.GoalsBttn.Name = "GoalsBttn";
            this.GoalsBttn.Size = new System.Drawing.Size(127, 68);
            this.GoalsBttn.TabIndex = 3;
            this.GoalsBttn.Text = "Weekly Goals";
            this.GoalsBttn.UseVisualStyleBackColor = true;
            this.GoalsBttn.Click += new System.EventHandler(this.GoalsBttn_Click);
            // 
            // AskFeedbackBttn
            // 
            this.AskFeedbackBttn.Location = new System.Drawing.Point(399, 26);
            this.AskFeedbackBttn.Name = "AskFeedbackBttn";
            this.AskFeedbackBttn.Size = new System.Drawing.Size(137, 68);
            this.AskFeedbackBttn.TabIndex = 4;
            this.AskFeedbackBttn.Text = "Active Feedback";
            this.AskFeedbackBttn.UseVisualStyleBackColor = true;
            this.AskFeedbackBttn.Click += new System.EventHandler(this.AskFeedbackBttn_Click);
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
            // FeedbackLogBttn
            // 
            this.FeedbackLogBttn.Location = new System.Drawing.Point(542, 26);
            this.FeedbackLogBttn.Name = "FeedbackLogBttn";
            this.FeedbackLogBttn.Size = new System.Drawing.Size(126, 68);
            this.FeedbackLogBttn.TabIndex = 5;
            this.FeedbackLogBttn.Text = "Feedback Log";
            this.FeedbackLogBttn.UseVisualStyleBackColor = true;
            this.FeedbackLogBttn.Click += new System.EventHandler(this.FeedbackLogBttn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogoutBttn);
            this.Controls.Add(this.FeedbackLogBttn);
            this.Controls.Add(this.AskFeedbackBttn);
            this.Controls.Add(this.LogoPicBx);
            this.Controls.Add(this.GoalsBttn);
            this.Controls.Add(this.HomeBttn);
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicBx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button LogoutBttn;
        private Button HomeBttn;
        private Button GoalsBttn;
        private Button AskFeedbackBttn;
        private PictureBox LogoPicBx;
        private Button FeedbackLogBttn;
    }
}