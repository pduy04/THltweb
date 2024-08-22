using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bai11
{
    public partial class XuLy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string hoTen = Request.Form["ipTen"];
            string ngaySinh = Request.Form["ipDate"];
           if (hoTen==null)
           {
               Response.Redirect("htmlForm.html");
            }
            else {
         
                NhanVien nv = new NhanVien(hoTen, DateTime.Parse(ngaySinh));
                List<NhanVien> listNV = (List<NhanVien>) Session["danhsach"];
                listNV.Add(nv);
                String str = "";
                int i = 1;
                foreach(NhanVien nhanvien in listNV)
                {
                    str += "<tr><td>"+ (i++) +"</td><td>"+ nhanvien.HoTen.ToString()+"</td><td>"+nhanvien.NamSinh.ToString("dd/MM/yyyy") +"</td></tr>";
                }
                ltTable.Text = str;
            }
        }
    }
}