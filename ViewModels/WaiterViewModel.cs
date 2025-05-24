using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1076_Radu_Bogdan_PROJ.ViewModels
{
    public class WaiterViewModel : INotifyPropertyChanged
    {
        private int _waiterId;
        public int WaiterId
        {
            get => _waiterId;
            set
            {
                if (_waiterId != value)
                {
                    _waiterId = value;
                    OnPropertyChanged(nameof(WaiterId));
                }
            }
        }

        private string _waiterName;
        public string WaiterName
        {
            get => _waiterName;
            set
            {
                if (_waiterName != value)
                {
                    _waiterName = value;
                    OnPropertyChanged(nameof(WaiterName));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public WaiterViewModel() { }

        public WaiterViewModel(Waiter model)
        {
            WaiterId = model.WaiterId;
            WaiterName = model.WaiterName;
        }

        public Waiter ToModel() => new Waiter
        {
            WaiterId = WaiterId,
            WaiterName = WaiterName
        };
    }
}
