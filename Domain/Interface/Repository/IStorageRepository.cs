using Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface.Repository
{
    public interface IStorageRepository
    {
        Task <Storage> AddStorage (Storage storage);
        Task <bool> DeleteStorage (Guid id);
        Task<Storage> GetStorage(Guid id);
        
    }
}
