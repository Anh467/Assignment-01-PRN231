using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    internal class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }  
        public int CategoryId { get; set; }
        [Column(TypeName = "Nvarchar(50)")]
        public string ProductName {  get; set; }    
        public double Weight {  get; set; }
        public decimal UnitPrice { get; set; } 
        public int UnitsInStock { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public virtual Category? Category { get; set; }
        public virtual ICollection<OrderDetail>? OrderDetails { get; set; }
    }
}
