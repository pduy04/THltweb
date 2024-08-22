using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bai12
{
    public partial class SendMessen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string mess = Request.Form["ipMessenger"];
            if(mess != null)
            {
                ArrayList listND = (ArrayList)Application["noidung"];
                User user = (User)Session["user"];
                string time =  DateTime.Now.ToShortTimeString();
                listND.Add(new Messenger(user.name, user.color, mess, time));
                Response.Redirect("SendMessen.html");
            }
        }
    }
}