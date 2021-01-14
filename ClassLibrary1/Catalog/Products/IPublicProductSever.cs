using System;

using System.Threading.Tasks;
using WebOnline.ViewModel.Catalog.Product;
using WebOnline.ViewModel.Catalog.Product.Public;
using WebOnline.ViewModel.Common;

namespace WebOnline.Applica.Catalog.Products
{
    public interface IPublicProductSever
    {
        Task<PageViewModel<ProductViewModel>> GetAllCatagoryId(GetProductPadingrequest request);
    }

}
