using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webonline.Data.EF;

namespace Webonline.Data.Entities
{
    public class MonHocKhoa
    {
        public int MonhocID { set; get; }
        public MonHoc monHoc { set; get; }
        public int KhoaID { set; get; }
        public Khoa Khoa { set; get; }
    }
}
