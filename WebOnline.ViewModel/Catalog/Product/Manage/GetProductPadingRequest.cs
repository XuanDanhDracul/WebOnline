
using System.Collections.Generic;
using WebOnline.ViewModel.Common;

namespace WebOnline.ViewModel.Catalog.Product.Manage
{
    public class GetProductPadingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
        public List<int> CatagoryIds { set; get; }

    }
}
