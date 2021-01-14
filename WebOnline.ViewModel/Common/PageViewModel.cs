using System;
using System.Collections.Generic;

namespace WebOnline.ViewModel.Common
{
    public class PageViewModel<T>
    {
        public List<T> item { get; set; }
        public int TotalRecord { set; get; }
    }
}
