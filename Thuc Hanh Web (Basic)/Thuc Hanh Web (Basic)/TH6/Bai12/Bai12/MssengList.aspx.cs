using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bai12
{
    public partial class MssengList : System.Web.UI.Page
    {
        public int ArrayList { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            ArrayList listND = (ArrayList)Application["noidung"];
            if (listND != null)
            {
                User user = (User)Session["user"];
                foreach(Messenger messenger in listND)
                {
                    if(user.name == messenger.username)
                    {
                        Response.Write("<p style='color:" + messenger.color + ";text-align: right;'><b>" + messenger.username + ":&nbsp;" 
                            + messenger.messen + "&nbsp;(" + messenger.time + ")</b></p>");
                    }
                    else
                    {
                        Response.Write("<p style='color:" + messenger.color + "'>" + messenger.username + ":&nbsp;"
                            + messenger.messen + "&nbsp;(" + messenger.time + ")</p>");
                    }
                }
            }
        }
    }
}