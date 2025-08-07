using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface.Repository
{
    public interface IHandleRepository
    {
        Task<Handle> Add (Handle handle);
        Task<bool> Delete (Guid id);
        Task<IEnumerable<Handle>> GetAll ();
        Task<Handle> GetHandle (Guid id);
    }
}
