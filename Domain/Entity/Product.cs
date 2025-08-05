using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Product
    {
        [Key]
        public Guid Id {  get; private set; } = Guid.NewGuid();

        public string Name { get; set; }
        public double Price { get; set; }
        public Category categoryId;
        
        public Product()
        { }
    }
}
