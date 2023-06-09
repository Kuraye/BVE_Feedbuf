﻿using System;
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
    public partial class ActiveFeedback : Form
    {
        public ActiveFeedback()
        {
            InitializeComponent();
        }

        private void HomeBttn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void WeeklyGoalBttn_Click(object sender, EventArgs e)
        {
            WeeklyGoals weekgoal = new WeeklyGoals();
            weekgoal.Show();
            this.Hide();
        }

        private void FeedbackLogBttn_Click(object sender, EventArgs e)
        {
            FeedbackLog log = new FeedbackLog();
            log.Show();
            this.Hide();
        }

        private void LogoutBttn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void ReactBttn_Click(object sender, EventArgs e)
        {
            Reactpanel.Visible = true;
        }

        private void SendBttn_Click(object sender, EventArgs e)
        {
            Reactpanel.Visible = false;
        }

        private void Inbox_Load(object sender, EventArgs e)
        {
            Reactpanel.Visible = false;

        }

        private void SubtaskDetail_Click(object sender, EventArgs e)
        {
            Detailpanel.Visible = true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reactpanel.Show();
        }
    }
}
