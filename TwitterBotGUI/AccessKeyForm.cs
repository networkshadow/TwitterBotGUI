using LiteDB;
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

namespace TwitterBotGUI
{
    public partial class AccessKeyForm : Form
    {
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

                //Index the table
                data.EnsureIndex(x => x.ID);

                //Get count of rows
                int numRows = data.Count();

                if(numRows < 1)
                {
                    var conf = new Config
                    {
                        ID = 1,
                        ConsumerKey = txtConsumerKey.Text,
                        ConsumerKeySecret = txtConsumerSecret.Text,
                        AccessToken = txtAccessToken.Text,
                        AccessTokenSecret = txtAccessTokenSecret.Text
                    };

                    data.Insert(conf);
                }
                else
                {
                    var conf = new Config
                    {
                        ID = 1,
                        ConsumerKey = txtConsumerKey.Text,
                        ConsumerKeySecret = txtConsumerSecret.Text,
                        AccessToken = txtAccessToken.Text,
                        AccessTokenSecret = txtAccessTokenSecret.Text
                    };

                    data.Update(conf);
                }
            }
        }
    }
}
