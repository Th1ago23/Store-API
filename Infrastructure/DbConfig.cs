using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class DbConfig:DbContext
    {
        public DbConfig (DbContextOptions<DbConfig> options) : base(options)
        { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Handle> Handles { get; set; }
        public DbSet<Storage> Storages { get; set; }
    }
}
