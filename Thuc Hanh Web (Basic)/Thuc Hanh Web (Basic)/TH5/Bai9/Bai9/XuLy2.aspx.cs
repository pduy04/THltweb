using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bai9
{
    public partial class XuLy2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                Response.ContentType = "text/xml";
                Response.ContentEncoding = System.Text.Encoding.UTF8;
                string xml = "<XuLy>" +
                       "<TenVXL>" + Request.QueryString.Get("ten") + "</TenVXL>"
                       + "<HangSX>" + Request.QueryString.Get("hang") + "</HangSX>"
                       + "<NgayRM>" + formatDate(Request.QueryString.Get("ngay")) + "</NgayRM>"
                       + "<Gia>" + Request.QueryString.Get("gia") + "</Gia>"
                       + "</XuLy>";
                Response.Write(xml);
                Response.End();
            }
            
        }
        private string formatDate(string date)
            {
                string[] arr = date.Split('-');
                return arr[2] + "/" + arr[1] + "/" + arr[0];
            }
    }
}