using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface.Repository
{
    public interface IProductRepository
    {
        Task<Product> GetProduct(Guid id);
        Task<IEnumerable<Product>> GetAllProducts();
        Task<Product> Create(Product product);
        Task<bool> Delete(Guid id);
        Task<Product> Update(Guid id);
    }
}
