using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface.Repository
{
    public interface ICategoryRepository
    {
        Task<Category> Create(Category category);
        Task<bool> Delete (int id);
        
    }
}
