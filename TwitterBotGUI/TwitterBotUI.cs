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

namespace TwitterBotGUI
{
    public partial class TwitterBotUI : Form
    {
        private TwitterService service;
        public TwitterBotUI(Config config)
        {
            InitializeComponent();
            service = new TwitterService(config.ConsumerKey, config.ConsumerKeySecret, config.AccessToken, config.AccessTokenSecret);
        }
    }
}
