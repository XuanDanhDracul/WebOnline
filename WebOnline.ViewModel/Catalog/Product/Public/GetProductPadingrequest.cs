using WebOnline.ViewModel.Common;

namespace WebOnline.ViewModel.Catalog.Product.Public
{
    public class GetProductPadingrequest : PagingRequestBase
    {
        public int? CatagoryId { get; set; }
    }
}
