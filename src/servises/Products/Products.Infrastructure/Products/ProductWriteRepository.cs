using Products.Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Infrastructure.Products
{
    public class ProductWriteRepository : IProductWriteRepository
    {
        private readonly ProductDbContext _context;
        public ProductWriteRepository(ProductDbContext context)
        {
            _context = context;
        }

        public async Task<Product> AddProduct(Product product)
        {
            var productEntity = await _context.AddAsync(product);
            await _context.SaveChangesAsync();
            return productEntity.Entity;
        }

        public async Task<Product> UpdateProduct(Product product)
        {

            var productEntity = _context.Update(product);
            await _context.SaveChangesAsync();
            return productEntity.Entity;
        }

        public async Task<bool> DeleteProduct(Product product)
        {
            _context.Remove(product);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
