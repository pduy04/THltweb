using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bai12
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Request.Form.Get("ipUser");
            string color = Request.Form.Get("ipColor");
            if (name == null || color == null)
            {
                Response.Redirect("Login.html");
            }
            else
            {
                User user = (User)Session["user"];
                user.name = name;
                user.color = color;
                ArrayList listUser = (ArrayList)Application["user"];
                listUser.Add(new User(name,color));

            }

        }
    }
}