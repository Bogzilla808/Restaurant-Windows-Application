using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _1076_Radu_Bogdan_PROJ
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderId { get; set; }

        [Required]
        public float orderTotal { get; set; }

        public Order() { 
            this.orderTotal = 0;
        }

        public Order(float orderTotal) {
            this.orderTotal = orderTotal;
        }
    }
}
