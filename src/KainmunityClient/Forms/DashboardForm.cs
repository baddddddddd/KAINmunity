﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KainmunityClient.ServerAPI;
using System.Text.Json;

namespace KainmunityClient.Forms
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            this.Load += Dashboard_Load;
        }

        private async void Dashboard_Load(object sender, EventArgs e)
        {
            var res = await AccountManager.GetAccountInfo();
            firstName.Text = res["UserFirstName"] as string;
        }
        private void donationBox_Click(object sender, EventArgs e)
        {
            Hide();
            if (APIConnector.AccountType == "Admin")
            {
                new DonationApprovalForm().Show();
            }
            else
            {
                new DonationForm().Show();
            }
        }
        private void requestButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (APIConnector.AccountType == "Admin")
            {
                new RequestApprovalForm().Show();
            }
            else
            {
                new RequestForm().Show();
            }
        }
        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UserProfileForm(APIConnector.UserId).Show();
        }

        private void showFeedbackButton_Click(object sender, EventArgs e)
        {
            if (APIConnector.AccountType == "Admin")
            {
                this.Hide();
                new DisplayFeedbackForm().Show();
            }
            else
            {
                if (feedbackPanel.Visible)
                {
                    feedbackPanel.Visible = false;
                }
                else
                {
                    feedbackPanel.Visible = true;
                }
            }
        }

        private async void sendFeedback(object sender, EventArgs e)
        {
            bool isSuccess = await FeedbackManager.AddFeedback(feedbackTextBox.Text);
            if (isSuccess)
            {
                error.ForeColor = Color.Green;
                error.Text = "Feedback sent";
            }
            else
            {
                error.ForeColor = Color.Red;
                error.Text = "Failed to send feedback";
            }

        }

        private void toLeaderboard(object sender, EventArgs e)
        {
            this.Hide();
            Leaderboard lead = new Leaderboard();
            lead.Show();
        }
    }
}
