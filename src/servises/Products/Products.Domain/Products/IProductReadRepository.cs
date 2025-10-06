using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Domain.Products
{
    public interface IProductReadRepository
    {
        public Task<List<Product>> GetAllAsync();
        public Task<Product> GetAsync(int id);
        public Task<Product> GetAsyncNoTracking(int id);
    }
}
