using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webonline.Data.EF;
using WebOnline.ViewModel.Catalog.Product;
using WebOnline.ViewModel.Catalog.Product.Public;
using WebOnline.ViewModel.Common;

namespace WebOnline.Applica.Catalog.Products
{
    public class PublicProductSevice : IPublicProductSever
    {
        private readonly SchoolDbConnect _context;
        public PublicProductSevice(SchoolDbConnect context)
        {
            _context = context;
        }
        public async Task<PageViewModel<ProductViewModel>> GetAllCatagoryId(GetProductPadingrequest request)
        {
            var query = from b in _context.SinhViens
                        join m in _context.Khoas on b.IdKhoa equals m.IdKhoa
                        join sk in _context.sinh_Mons on b.id equals sk.SinhvienId
                        select new
                        {
                            b,
                            m
                        };
            if (request.CatagoryId.HasValue && request.CatagoryId.Value > 0)
            {
                query = query.Where(p => p.b.id == request.CatagoryId);
            }
            int tatolRow = await query.CountAsync();
            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x => new ProductViewModel()
                {
                    id = x.b.id,
                    Name = x.b.Name,
                    MaSV = x.b.MaSV,
                    IdKhoa = x.m.IdKhoa,
                }).ToListAsync();

            var PageViewModel = new PageViewModel<ProductViewModel>()
            {
                item = data
            };
            return PageViewModel;
        }
    }
}
