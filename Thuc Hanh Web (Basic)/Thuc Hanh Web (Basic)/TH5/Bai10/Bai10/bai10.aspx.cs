using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bai10
{
    public partial class bai10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
              
                 try
                {
                    if (txtFile.FileContent.Length > 0)
                    {
                        txtFile.SaveAs(Server.MapPath("App_Data/") + txtFile.FileName);
                        Response.Write("<script>alert('Upload File thanh cong')</script>");
                    }
                }
                catch (Exception)
                {
                    Response.Write("<script>alert('Upload File that bai')</script>");
                }
            }
            
        }
    }
}