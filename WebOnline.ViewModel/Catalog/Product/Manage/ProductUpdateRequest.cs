using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebOnline.ViewModel.Catalog.Product.Manage
{
    public class ProductUpdateRequest
    {
        public int id { get; set; }
        public string Name { set; get; }
        public string MaSV { set; get; }
        public IFormFile ThambuiImage { set; get; }
    }
}
