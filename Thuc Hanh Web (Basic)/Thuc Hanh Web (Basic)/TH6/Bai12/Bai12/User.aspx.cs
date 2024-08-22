using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bai12
{
    public partial class User1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ArrayList listUser = (ArrayList)Application["user"];
            if(listUser != null)
            {
                User user = (User)Session["user"];
                foreach(User u in listUser)
                {
                    if (u.name == user.name)
                    {
                        Response.Write("<p style='color:" + u.color + "'><b><u>" + u.name + "</u></b></p>");
                    }
                    else
                    {
                        Response.Write("<p style='color:" + u.color + "'>" + u.name + "</p>");
                    }
                }
            }
        }
    }
}