using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface.Repository
{
    public interface IStorageRepository
    {
        Task<Storage> CreateStorage (Storage storage);
        Task DeleteStorage (Storage storage);
        Task<Storage> GetStorage (Guid id);
    }
}
