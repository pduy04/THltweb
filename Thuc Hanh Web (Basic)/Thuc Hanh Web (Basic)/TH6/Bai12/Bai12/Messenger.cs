using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai12
{
    public class Messenger
    {
        public string username;
        public string color;
        public string messen;
        public string time;
        public Messenger(string username, string color, string messen, string time)
        {
            this.username = username;
            this.color = color;
            this.messen = messen;
            this.time = time;
        }
//        public Messenger() {}
    }
}