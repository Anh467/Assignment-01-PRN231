using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    internal class OrderDetail
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public double Discount { get; set; }

        [ForeignKey(nameof(OrderId))]
        public virtual Order? Order { get; set; }
        [ForeignKey(nameof(ProductId))]
        public virtual Product? Product { get; set; }
    }
}
