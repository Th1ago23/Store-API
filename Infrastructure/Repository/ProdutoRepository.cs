using Domain.Entity;
using Domain.Interface.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly DbConfig _config;
        public ProductRepository(DbConfig config)
        {
            _config = config;
        }
        public async Task<Product> GetProduct(Guid id)
        {
            try
            {
                var produto = await _config
                                        .Products
                                        .FirstOrDefaultAsync(x => x.Id == id)
                                        ?? throw new Exception($"Não foi encontrado nenhum produto com o ID {id}");

                return produto;

            }
            catch (DbException e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            try
            {
                return await _config
                                .Products
                                .ToListAsync();
            }
            catch (DbException e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}