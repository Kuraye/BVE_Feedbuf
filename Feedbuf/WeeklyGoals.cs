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
    public partial class WeeklyGoals : Form
    {
        public WeeklyGoals()
        {
            InitializeComponent();
        }

        private void HomeBttn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void LogoutBttn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void FeedbackLogBttn_Click(object sender, EventArgs e)
        {
            FeedbackLog feedbacklog = new FeedbackLog();
            this.Hide();
            feedbacklog.Show();
        }

        private void FeedbackBttn_Click(object sender, EventArgs e)
        {
            Inbox inbox = new Inbox();
            this.Hide();
            inbox.Show();
        }

        private void WeeklyGoalsBttn_Click(object sender, EventArgs e)
        {

        }

        private void CreateBttn_Click(object sender, EventArgs e)
        {

        }
    }
}
