using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feedbuf
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void LogoutBttn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void LogoPicBx_Click(object sender, EventArgs e)
        {

        }

        private void HomeBttn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void GoalsBttn_Click(object sender, EventArgs e)
        {
            WeeklyGoals weekgoal = new WeeklyGoals();
            weekgoal.Show();
            this.Hide();
        }

        private void AskFeedbackBttn_Click(object sender, EventArgs e)
        {
            ActiveFeedback inbox = new ActiveFeedback();
            inbox.Show();
            this.Hide();
        }

        private void FeedbackLogBttn_Click(object sender, EventArgs e)
        {
            FeedbackLog feedbacklog = new FeedbackLog();
            this.Hide();
            feedbacklog.Show();
        }
    }
}
