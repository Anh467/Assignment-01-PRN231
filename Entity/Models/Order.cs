using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    internal class Order
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        public int MemberId { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public DateTime RequiredDate { get; set; } = DateTime.Now;
        public DateTime ShippedDate { get; set; } = DateTime.Now;
        public decimal Freight { get; set; }

        [ForeignKey(nameof(MemberId))]
        public virtual Member? Member { get; set; }  
        public virtual ICollection<OrderDetail>? OrderDetails { get; set; }
    }
}
