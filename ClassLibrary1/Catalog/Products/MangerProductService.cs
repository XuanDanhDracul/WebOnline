using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using Webonline.Data.EF;
using WebOnline.ViewModel.Catalog.Product;
using WebOnline.ViewModel.Catalog.Product.Manage;
using WebOnline.ViewModel.Common;

namespace WebOnline.Applica.Catalog.Products
{
    public class MangerProductService : IMangerProductSever
    {
        private readonly SchoolDbConnect _context;
        public MangerProductService(SchoolDbConnect context)
        {
            _context = context;
        }

        public async Task addViewcount(int productId)
        {
            var product = await _context.SinhViens.FindAsync(productId);
            product.id += 1;
            await _context.SaveChangesAsync();
        }

        public async Task<int> Create(ProductCreateRequest request)
        {
            var sinhVien = new SinhVien()
            {
                MaSV = request.MaSV,
                Name = request.Name,
            };
            _context.SinhViens.Add(sinhVien);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(int productID)
        {
            var product = await _context.SinhViens.FindAsync(productID);
            if (product == null) throw new Exception($"Cannot find a product :{productID}");
            _context.SinhViens.Remove(product);
            return await _context.SaveChangesAsync();
        }

        public async Task<PageViewModel<ProductViewModel>> GetAllPaging(GetProductPadingRequest request)
        {
            var query = from b in _context.SinhViens
                        join m in _context.Khoas on b.IdKhoa equals m.IdKhoa
                        join sk in _context.sinh_Mons on b.id equals sk.SinhvienId
                        select new
                        {
                            b,
                            m
                        };
            if (!string.IsNullOrEmpty(request.Keyword))
                query = query.Where(x => x.m.IdKhoa.ToString().Contains(request.Keyword));
            if (request.CatagoryIds.Count > 0)
            {
                query = query.Where(p => request.CatagoryIds.Contains(p.b.id));
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

        public async Task<int> Update(ProductUpdateRequest request)
        {
            var product = await _context.SinhViens.FindAsync(request.id);
            if (product == null) throw new Exception($"Cannot find product {request.id}");
            product.id = request.id;
            product.Name = request.Name;
            product.MaSV = request.MaSV;
            return await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdateKhoaId(int productID, int productIDKh)
        {
            var product = await _context.SinhViens.FindAsync(productID);
            if (product == null) throw new Exception($"Cannot find productid: {productID}");
            product.IdKhoa = productIDKh;
            return await _context.SaveChangesAsync() > 0;
        }
        private async Task<string> SaveFile(IFormFile file)
        {
            var OgrinalName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim().ToString();
            var filename = $"{Guid.NewGuid()} {Path.GetExtension(OgrinalName)}";
            await
        }

    }
}
