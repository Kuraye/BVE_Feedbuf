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
    public partial class FeedbackLog : Form
    {
        public FeedbackLog()
        {
            InitializeComponent();
        }

        private void LogoutBttn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void HomeBttn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void WeeklyGoalsBttn_Click(object sender, EventArgs e)
        {
            WeeklyGoals weekgoal = new WeeklyGoals();
            weekgoal.Show();
            this.Hide();
        }

        private void FeedbackBttn_Click(object sender, EventArgs e)
        {
            ActiveFeedback inbox = new ActiveFeedback();
            inbox.Show();
            this.Hide();
        }
    }
}
