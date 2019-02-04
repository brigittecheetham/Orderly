using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{

    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerReference { get; set; }
        public bool Despatched { get; set; }

        public virtual ICollection<OrderLine> OrderLines { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
    
}
