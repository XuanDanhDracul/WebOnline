using System;
using System.Collections.Generic;
using Webonline.Data.Entities;

namespace Webonline.Data.EF
{
    public class SinhVien
    {
        public int id { set; get; }
        public string Name { set; get; }
        public string MaSV { set; get; }
        public int IdKhoa { set; get; }
        public ICollection<Sinh_Mon> SinhMon { set; get; }
        public Khoa Khoa { set; get; }
    }
}
