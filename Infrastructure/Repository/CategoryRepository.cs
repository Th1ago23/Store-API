using Domain.Entity;
using Domain.Interface.Repository;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class CategoryRepository:ICategoryRepository
    {
        private readonly DbConfig _context;
        
        public CategoryRepository (DbConfig context)
        {
            _context = context;
        }

        public async Task Create (Category category)
        {
            try
            {
                await _context
                .Categories
                .AddAsync(category);

            } catch (DbException ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
        
        public async Task<bool> Update (Category category)
        {
            try
            {
                    _context
                        .Categories
                        .Update(category);
                    return true;
            }
            catch (DbException ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
    }
}
