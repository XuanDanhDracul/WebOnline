
using System.Collections.Generic;

using Webonline.Data.EF;

namespace WebOnline.ViewModel.Catalog.Product
{
    public class ProductViewModel
    {
        public int id { set; get; }
        public string Name { set; get; }
        public string MaSV { set; get; }
        public int IdKhoa { set; get; }
        public int ViewCount { set; get; }
        public List<MonHoc> mons { set; get; }
    }
}
