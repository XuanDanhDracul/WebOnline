using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webonline.Data.Entities;

namespace Webonline.Data.EF
{
    public class Khoa
    {
        public int IdKhoa { set; get; }
        public int KhoaID { set; get; }
        public string TenKhoa { set; get; }
        public ICollection<SinhVien> SinhViens { get; set; }
        public ICollection<MonHocKhoa> MonHocKhoa { set; get; }
    }
}
