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

namespace TwitterBotGUI
{
    public partial class TwitterBotUI : Form
    {
        private TwitterService service;
        private Config config;
        public TwitterBotUI(Config config)
        {
            InitializeComponent();
            this.config = config;
            service = new TwitterService(config.ConsumerKey, config.ConsumerKeySecret, config.AccessToken, config.AccessTokenSecret);
        }

        private void TwitterBotUI_Load(object sender, EventArgs e)
        {
            var user = service.GetUserProfile(new GetUserProfileOptions()).ScreenName;
            this.Text = $"@{user}'s Automation Dashboard";
            //Console.WriteLine(user);
            /*var _status = "Bot has officially started.";

            service.SendTweet(new SendTweetOptions { Status = _status }, (tweet, response) =>
            {
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"<{DateTime.Now}> - Tweet Sent: {_status}");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"<ERROR> " + response.Error.Message);
                    Console.ResetColor();
                }
            });*/
        }
    }
}
