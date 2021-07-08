using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwitterBotGUI.Objects;
using TweetSharp;
using System.Net;
using System.Threading;

namespace TwitterBotGUI
{
    public partial class TwitterBotUI : Form
    {
        private TwitterService service;
        private Config config;

        private Thread autoTweetThr;
        private Thread autoReplyThr;
        public TwitterBotUI(Config config)
        {
            InitializeComponent();
            this.config = config;
            service = new TwitterService(config.ConsumerKey, config.ConsumerKeySecret, config.AccessToken, config.AccessTokenSecret);
        }

        private void TwitterBotUI_Load(object sender, EventArgs e)
        {
            try
            {
                var user = service.GetUserProfile(new GetUserProfileOptions()).ScreenName;
                this.Text = $"@{user}'s Automation Dashboard";
            }
            catch(Exception)
            {
                MessageBox.Show("Error authenticating user. Please check your keys and secrets and try again.");
                this.Close();

                Thread thread = new Thread(OpenAccessKeyPage);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
        }

        private void OpenAccessKeyPage() => Application.Run(new AccessKeyForm());

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("Are you sure you want to exit the application?", "Confirm Exit", MessageBoxButtons.OKCancel);
            
            if(answer == DialogResult.OK)
            {
                Application.Exit();
            }            
        }

        private void changeProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("Are you sure you would like to change access?", "Confirm", MessageBoxButtons.OKCancel);

            if(answer == DialogResult.OK)
            {
                this.Close();
                Thread thread = new Thread(OpenAccessKeyPage);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
        }

        private void btnAddTweet_Click(object sender, EventArgs e)
        {
            var tweet = txtTweet.Text;

            if (!String.IsNullOrWhiteSpace(tweet))
            {
                listViewAutoTweets.Items.Add(tweet);
            }
            else
            {
                MessageBox.Show("Please enter text for a tweet.");
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to clear all the auto-tweets?", "Confirm", MessageBoxButtons.YesNo);

            if(confirm == DialogResult.Yes)
            {
                listViewAutoTweets.Items.Clear();
            }
        }
    }
}
