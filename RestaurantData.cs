using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1076_Radu_Bogdan_PROJ
{
    [Serializable]
    public class RestaurantData
    {
        public List<Order> Orders { get; set; }
        public List<Waiter> Waiters { get; set; }
        public List<Reservation> Reservations { get; set; }
    }
}
