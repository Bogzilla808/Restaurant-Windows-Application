using _1076_Radu_Bogdan_PROJ.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1076_Radu_Bogdan_PROJ
{
    public partial class ReservationForm : Form
    {
        private List<Reservation> reservations = new List<Reservation>();
        private List<Order> orders = new List<Order>();
        private List<Waiter> waiters = new List<Waiter>();

        private Reservation originalReservation;
        private ReservationViewModel viewModel;

        public ReservationForm(List<Reservation> reservations, List<Order> orders, List<Waiter> waiters, Reservation reservationToEdit = null)
        {
            InitializeComponent();
            this.reservations = reservations;
            this.orders = orders;
            this.waiters = waiters;

            if (reservationToEdit != null)
            {
                //resIdInput.Text = reservationToEdit.ReservationId.ToString();
                //resPersonInput.Text = reservationToEdit.NoPersons.ToString();
                //resOrderInput.Text = reservationToEdit.OrderId.ToString();
                //resWaiterInput.Text = reservationToEdit.WaiterId.ToString();
                originalReservation = reservationToEdit;
                viewModel = new ReservationViewModel(reservationToEdit);
                resIdInput.Enabled = false;
                resAddBtn.Text = "Update";
            }
            else
            {
                viewModel = new ReservationViewModel();
            }

            resIdInput.DataBindings.Add("Text", viewModel, nameof(viewModel.ReservationId), true, DataSourceUpdateMode.OnPropertyChanged);
            resPersonInput.DataBindings.Add("Text", viewModel, nameof(viewModel.NoPersons), true, DataSourceUpdateMode.OnPropertyChanged);
            resOrderInput.DataBindings.Add("Text", viewModel, nameof(viewModel.OrderId), true, DataSourceUpdateMode.OnPropertyChanged);
            resWaiterInput.DataBindings.Add("Text", viewModel, nameof(viewModel.WaiterId), true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {

        }

        private void resAddBtn_Click(object sender, EventArgs e)
        {
            ep_res.Clear();

            if (!uint.TryParse(resIdInput.Text, out var id) || id < 0)
            {
                ep_res.SetError(resIdInput, "Invalid or negative value");
                return;
            }

            if (!uint.TryParse(resPersonInput.Text, out var noPersons) || noPersons < 0)
            {
                ep_res.SetError(resPersonInput, "Invalid or negative value");
                return;
            }

            if(!uint.TryParse(resOrderInput.Text, out var orderId) || orderId < 0 || !orders.Any(o => o.OrderId == orderId))
            {
                ep_res.SetError(resOrderInput, "Invalid or negative value");
                return;
            }

            if (!uint.TryParse(resWaiterInput.Text, out var waiterId) || !waiters.Any(w => w.WaiterId == waiterId))
            {
                ep_res.SetError(resWaiterInput, "Waiter ID does not exist");
                return;
            }

            var model = viewModel.ToModel();

            try
            {
                if (originalReservation != null)
                {
                    reservations.Remove(originalReservation);
                    model.ReservationId = originalReservation.ReservationId;
                    DatabaseHelper.UpdateReservation(model);
                }
                else
                {
                    if (reservations.Any(r => r.ReservationId == model.ReservationId))
                    {
                        MessageBox.Show("A reservation with this ID already exists.");
                        return;
                    }
                    DatabaseHelper.AddReservation(model);
                }
                reservations.Add(model);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save reservation: " + ex.Message);
            }
        }
    }
}
