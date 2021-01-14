using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webonline.Data.EF;

namespace Webonline.Data.Entities
{
    public class ProductImage
    {
        public int id { get; set; }
        public int productID { get; set; }
        public string path { get; set; }
        public string Caption { set; get; }
        public bool Isdefault { get; set; }
        public DateTime CreateIma { set; get; }
        public int SortImage { set; get; }
        public int FileSize { set; get; }
        public SinhVien sinhVien { set; get; }
    }
}
