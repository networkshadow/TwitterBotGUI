using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterBotGUI.Objects
{
    public class Config
    {
        public int ID { get; set; }
        public string ConsumerKey { get; set; }
        public string ConsumerKeySecret { get; set; }
        public string AccessToken { get; set; }
        public string AccessTokenSecret { get; set; }
    }
}
