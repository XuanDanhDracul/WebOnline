
using Microsoft.AspNetCore.Http;

namespace WebOnline.ViewModel.Catalog.Product.Manage
{
    public class ProductCreateRequest
    {
        public string Name { set; get; }
        public string MaSV { set; get; }
        public IFormFile ThambuiImage { set; get; }
    }
}
