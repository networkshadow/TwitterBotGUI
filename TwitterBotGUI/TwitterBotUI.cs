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
        private delegate void SafeCall(string txt);

        private TwitterService service;
        private Config config;

        private Thread autoTweetThr;
        private Thread autoReplyThr;

        private List<string> allTweets;
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
            catch (Exception)
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

            if (answer == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void changeProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("Are you sure you would like to change access?", "Confirm", MessageBoxButtons.OKCancel);

            if (answer == DialogResult.OK)
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
                txtTweet.Clear();
            }
            else
            {
                MessageBox.Show("Please enter text for a tweet.");
            }

            txtTweet.Focus();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to clear all the auto-tweets?", "Confirm", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                listViewAutoTweets.Items.Clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e) => txtTweet.Clear();

        private void btnStartAutoTweet_Click(object sender, EventArgs e)
        {
            if (ValidAutoTweet())
            {
                //Get all tweets to auto-tweet
                List<string> tweets = new List<string>();


                for(var i = 0; i < listViewAutoTweets.Items.Count; i++)
                {
                    tweets.Add(listViewAutoTweets.Items[i].Text);
                }

                this.allTweets = tweets;

                listViewConsole.Items.Add($"<{DateTime.Now}> - Auto-Tweeting Started!").ForeColor = Color.Green;
                listViewConsole.ForeColor = Color.White;
                autoTweetThr = new Thread(AutoTweet);
                autoTweetThr.Start();

                ResetAutoTweetButtons();
            }
        }

        private bool ValidAutoTweet()
        {
            var isValid = true;
            var message = "";

            if (listViewAutoTweets.Items.Count < 1)
            {
                isValid = false;
                message += "You must add at least one tweet.\n";
            }
            if (numericHours.Value == 0 && numericMinutes.Value == 0 && numericSeconds.Value == 0)
            {
                isValid = false;
                message += "You must have a time between tweets.\n";
            }

            if (!isValid)
            {
                MessageBox.Show(message, "Error");
            }

            return isValid;
        }

        private void btnStopAutoTweet_Click(object sender, EventArgs e)
        {
            listViewConsole.Items.Add($"<{DateTime.Now}> - Auto-Tweeting Stopped").ForeColor = Color.Red;
            autoTweetThr.Abort();

            //Reset tab views
            ResetAutoTweetButtons();
        }

        private void ResetAutoTweetButtons()
        {
            btnStartAutoTweet.Enabled = !btnStartAutoTweet.Enabled;
            btnStopAutoTweet.Enabled = !btnStopAutoTweet.Enabled;
            txtTweet.Enabled = !txtTweet.Enabled;
            btnAddTweet.Enabled = !btnAddTweet.Enabled;
            btnClearAll.Enabled = !btnClearAll.Enabled;
            btnClear.Enabled = !btnClear.Enabled;
            numericHours.Enabled = !numericHours.Enabled;
            numericMinutes.Enabled = !numericMinutes.Enabled;
            numericSeconds.Enabled = !numericSeconds.Enabled;
        }

        private void AutoTweet()
        {
            //Create timeout from selected time on form
            var timeout = new TimeSpan((int)numericHours.Value, (int)numericMinutes.Value, (int)numericSeconds.Value);

            //Run indefinitely
            while (true)
            {
                var tweet = this.allTweets[new Random().Next(this.allTweets.Count - 1)];
                
                SafeAddToConsole($"<{DateTime.Now}> - Tweeted: {tweet}");

                //Do not repeat until timeout
                Thread.Sleep(timeout);
            }

        }

        private void SafeAddToConsole(string msg)
        {
            if (listViewConsole.InvokeRequired)
            {
                var d = new SafeCall(SafeAddToConsole);
                listViewConsole.Invoke(d, new object[] { msg });
            }
            else
            {
                listViewConsole.Items.Add(msg);
            }
        }
    }
}
