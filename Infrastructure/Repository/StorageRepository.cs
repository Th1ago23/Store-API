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
    public class StorageRepository:IStorageRepository
    {
        private readonly DbConfig _context;

        public StorageRepository(DbConfig context)
        {
            _context = context;
        }

        public async Task<Storage> AddStorage (Storage storage)
        {
            try
            {
                await _context
                        .Storages
                        .AddAsync(storage);

                return storage;
            }
            catch (DbException ex) 
            {
                throw new Exception(ex.Message);

            } catch (NullReferenceException e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<bool> DeleteStorage (Guid id)
        {
            try
            {
                var store = await _context
                                    .Storages
                                    .FirstOrDefaultAsync(s => s.id == id)
                                    ?? throw new Exception($"Não existe nenhum Estoque com o id {id}");

                _context.Storages.Remove(store);
                return true;
            } catch (DbException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Storage> GetStorage (Guid id)
        {
            try
            {
                var store = await _context
                    .Storages
                    .Where(s => s.productId != null)
                    .FirstOrDefaultAsync(s => s.id == id)
                    ?? throw new Exception($"Nenhum estoque encontrado com o id {id}.");

                return store;
            }catch (DbException e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}
