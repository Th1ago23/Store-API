using Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Storage
    {
        [Key]
        public Guid Id {  get; private set; }
        public string Name { get; private set; }
        public Guid? ProductId { get; private set; }
        public Product? Product { get; set; }
        public int? Quantity {  get; private set; }



        public void RemoveItem(int qnt)
        {
            if (qnt <= 0 && qnt > Quantity) throw new ArgumentException("Quantidade inválida!");
            Quantity -= qnt;
        }

        public void EntryItem(int qnt)
        {
            if (qnt <= 0) throw new ArgumentException("Quantidade inválida!");
            Quantity += qnt;
        }

    }
}
