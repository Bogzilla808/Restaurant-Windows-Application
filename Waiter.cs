using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _1076_Radu_Bogdan_PROJ
{
    public class Waiter
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WaiterId { get; set; }

        [Required]
        [MaxLength(50)]
        public string WaiterName { get; set; }

        public Waiter() { }

        public Waiter(string waiterName)
        {
            WaiterName = waiterName;
        }
    }
}
