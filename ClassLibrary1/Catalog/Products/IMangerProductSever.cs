using System;
using System.Threading.Tasks;
using WebOnline.ViewModel.Catalog.Product;
using WebOnline.ViewModel.Catalog.Product.Manage;
using WebOnline.ViewModel.Common;

namespace WebOnline.Applica.Catalog.Products
{
    public interface IMangerProductSever
    {
        Task<int> Create(ProductCreateRequest request);
        Task<int> Update(ProductUpdateRequest request);
        Task<int> Delete(int productID);
        Task<bool> UpdateKhoaId(int product, int productIdk);
        Task addViewcount(int productId);
        Task<PageViewModel<ProductViewModel>> GetAllPaging(GetProductPadingRequest request);
    }
}
