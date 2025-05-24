using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1076_Radu_Bogdan_PROJ.ViewModels
{
    public class OrderViewModel : INotifyPropertyChanged
    {
        private int orderId;
        private float orderTotal;

        public int OrderId 
        {
            get => orderId;
            set {  orderId = value; OnPropertyChanged(nameof(OrderId)); }
        }

        public float OrderTotal
        {
            get => orderTotal;
            set
            {
                orderTotal = value;
                OnPropertyChanged(nameof(OrderTotal));
            }
        }

        public OrderViewModel() { }

        public OrderViewModel(Order order)
        {
            OrderId = order.OrderId;
            OrderTotal = order.orderTotal;
        }

        public Order ToModel()
        {
            return new Order { OrderId = this.OrderId, orderTotal = this.OrderTotal };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
