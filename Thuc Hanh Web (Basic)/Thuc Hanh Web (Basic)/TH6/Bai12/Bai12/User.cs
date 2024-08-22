using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai12
{
   
    public class User
    {
        public string name;
        public string color;
        public User() { }
        public User(string name, string color)
        {
            this.name = name;
            this.color = color;
        }
    }
}