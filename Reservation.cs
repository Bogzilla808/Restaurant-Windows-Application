using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _1076_Radu_Bogdan_PROJ
{
    public class Reservation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReservationId { get; set; }
        [Range(1, 100)]
        public int NoPersons { get; set; }
        [ForeignKey(nameof(Order))]
        public int OrderId { get; set; }
        [ForeignKey(nameof(Waiter))]
        public int WaiterId { get; set; }

        public virtual Order Order { get; set; }
        public virtual Waiter Waiter { get; set; }

        public Reservation(int reservationId, int orderId, int waiterId, int noPersons)
        {
            this.ReservationId = reservationId;
            this.OrderId = orderId;
            this.WaiterId = waiterId;
            this.NoPersons = noPersons;
        }

        public Reservation()
        {
            
        }
    }
}
