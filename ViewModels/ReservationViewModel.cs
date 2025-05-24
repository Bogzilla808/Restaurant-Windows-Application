using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace _1076_Radu_Bogdan_PROJ.ViewModels
{
    public class ReservationViewModel : INotifyPropertyChanged
    {
        private int reservationId;
        private int noPersons;
        private int orderId;
        private int waiterId;

        public int ReservationId
        {
            get => reservationId;

            set
            {
                reservationId = value;
                OnPropertyChanged(nameof(ReservationId));
            }
        }

        public int NoPersons
        {
            get => noPersons;
            set
            {
                noPersons = value;
                OnPropertyChanged(nameof(NoPersons));
            }
        }

        public int OrderId
        {
            get => orderId;
            set
            {
                orderId = value;
                OnPropertyChanged(nameof(OrderId));
            }
        }

        public int WaiterId
        {
            get => waiterId;
            set
            {
                waiterId = value;
                OnPropertyChanged(nameof(WaiterId));
            }
        }

        public ReservationViewModel() { }

        public ReservationViewModel(Reservation res)
        {
            ReservationId = res.ReservationId;
            NoPersons = res.NoPersons;
            OrderId = res.OrderId;
            WaiterId = res.WaiterId;
        }

        public Reservation ToModel()
        {
            return new Reservation
            {
                ReservationId = this.ReservationId,
                NoPersons = this.NoPersons,
                OrderId = this.OrderId,
                WaiterId = this.WaiterId
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
