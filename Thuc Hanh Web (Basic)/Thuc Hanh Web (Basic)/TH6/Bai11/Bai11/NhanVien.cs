using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai11
{
    public class NhanVien
    {
        string hoTen;
        DateTime ngaySinh;
        public NhanVien(string hoTen, DateTime ngaySinh)
        {
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
        }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public DateTime NamSinh { get => ngaySinh; set => ngaySinh = value; }
    }
}