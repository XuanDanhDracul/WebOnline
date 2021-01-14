using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webonline.Data.EF;

namespace Webonline.Data.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public string firstname { set; get; }
        public string lastname { set; get; }
        public DateTime Dob { set; get; }
        public ICollection<ProductImage> productImages { set; get; }
    }
}
