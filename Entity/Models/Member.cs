using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    internal class Member
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MemberId { get; set; }
        [Required]
        [Column(TypeName = "Nvarchar(200)")]
        public string Email { get; set; }
        [Column(TypeName = "Nvarchar(50)")]
        public string City { get; set; }
        [Column(TypeName = "Nvarchar(50)")]
        public string Country { get; set; }
        [Required]
        [Column(TypeName = "Nvarchar(100)")]
        public string Password { get; set; }
        public virtual ICollection<Order>? Orders { get; set; }
    }
}
