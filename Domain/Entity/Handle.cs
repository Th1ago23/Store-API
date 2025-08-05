using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Handle
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public Guid ProductId { get; private set; }
        public int Quantity { get; set; }
        public HandleType TypeHandle { get; set; }
        public DateTime Data { get; set; }


        public Handle() { }
        public Handle(Guid productId, int quantity, HandleType typeHandle)
        {

            if (quantity <= 0) throw new ArgumentException("Quantidade deve ser maior que zero.");

            ProductId = productId;
            Quantity = quantity;
            TypeHandle = typeHandle;
            Data = DateTime.UtcNow;
        }
    }
}
