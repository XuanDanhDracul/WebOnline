using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webonline.Data.Entities;

namespace Webonline.Data.EF
{
    public class MonHoc
    {
        public int ID_Mon { set; get; }
        public string Ten_MH { set; get; }
        public int IdKhoa { set; get; }
        public ICollection<Sinh_Mon> SinhMon { set; get; }
        public ICollection<MonHocKhoa> MonHocKhoa { set; get; }
    }
}
