using LiteDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwitterBotGUI.Objects;

namespace TwitterBotGUI
{
    public partial class AccessKeyForm : Form
    {
        private Config config;
        private static string _strConnection = "FileName=configData.litedb4; Mode=Exclusive;";
        public AccessKeyForm()
        {
            InitializeComponent();
        }

        private void AccessKeyForm_Load(object sender, EventArgs e)
        {
            using(var db = new LiteDatabase(_strConnection))
            {
                var data = db.GetCollection<Config>("config");

                //Index the table
                data.EnsureIndex(x => x.ID);

                //Get count of rows
                int numRows = data.Count();

                if(numRows == 1)
                {
                    var result = data.FindAll().FirstOrDefault();

                    //Fill fields automatically
                    txtConsumerKey.Text = result.ConsumerKey.ToString();
                    txtConsumerSecret.Text = result.ConsumerKey.ToString();
                    txtAccessToken.Text = result.AccessToken.ToString();
                    txtAccessTokenSecret.Text = result.AccessTokenSecret.ToString();

                    chkSaveKeys.Checked = true;
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (FieldsComplete())
            {
                if (chkSaveKeys.Checked)
                {
                    UpdateLiteDB();
                }
                else
                {
                    //Drop "config" data from LiteDB
                    using (var db = new LiteDatabase(_strConnection))
                    {
                        db.DropCollection("config");
                    }
                }

                //Initialize global conf variable
                this.config = new Config
                {
                    ID = 1,
                    ConsumerKey = txtConsumerKey.Text,
                    ConsumerKeySecret = txtConsumerSecret.Text,
                    AccessToken = txtAccessToken.Text,
                    AccessTokenSecret = txtAccessTokenSecret.Text
                };

                //Close this form page
                this.Close();

                //Start UI in new thread
                Thread thread = new Thread(OpenTwitterBotUI);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else
            {
                MessageBox.Show("Please ensure all keys and secrets have been filled.");
            }
        }

        private bool FieldsComplete()
        {
            return !String.IsNullOrEmpty(txtAccessToken.Text)
                && !String.IsNullOrEmpty(txtAccessTokenSecret.Text)
                && !String.IsNullOrEmpty(txtConsumerKey.Text)
                && !String.IsNullOrEmpty(txtConsumerSecret.Text);
        }

        private void UpdateLiteDB()
        {
            using(var db = new LiteDatabase(_strConnection))
            {
                var data = db.GetCollection<Config>("config");

                var conf = new Config
                {
                    ID = 1,
                    ConsumerKey = txtConsumerKey.Text,
                    ConsumerKeySecret = txtConsumerSecret.Text,
                    AccessToken = txtAccessToken.Text,
                    AccessTokenSecret = txtAccessTokenSecret.Text
                };

                //Index the table
                data.EnsureIndex(x => x.ID);

                //Get count of rows
                int numRows = data.Count();

                if(numRows < 1)
                {
                    data.Insert(conf);
                }
                else
                {
                    data.Update(conf);
                }
            }
        }

        private void OpenTwitterBotUI() => Application.Run(new TwitterBotUI(this.config));
    }
}
