using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webonline.Data.EF;

namespace Webonline.Data.Entities
{
    public class Sinh_Mon
    {
        public int SinhvienId { set; get; }
        public SinhVien SinhVien { get; set; }
        public int Id_Mon { set; get; }
        public MonHoc MonHoc { set; get; }
    }
}
