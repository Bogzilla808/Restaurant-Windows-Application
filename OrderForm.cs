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
    public partial class OrderForm : Form
    {
        private List<Order> orders = new List<Order>();
        private Order originalOrder;
        private OrderViewModel viewModel;

        public OrderForm(List<Order> orders, Order orderToEdit = null)
        {
            InitializeComponent();
            this.orders = orders;

            if (orderToEdit != null)
            {
                originalOrder = orderToEdit;

                viewModel = new OrderViewModel(orderToEdit);

                orderIdInput.Text = originalOrder.OrderId.ToString();
                orderIdInput.Enabled = false;
                orderTotalInput.Text = originalOrder.orderTotal.ToString();
                orderSubmitBtn.Text = "Update Order";
            }
            else
            {
                viewModel = new OrderViewModel();
            }

            orderIdInput.DataBindings.Add("Text", viewModel, nameof(viewModel.OrderId), true, DataSourceUpdateMode.OnPropertyChanged);
            orderTotalInput.DataBindings.Add("Text", viewModel, nameof(viewModel.OrderTotal), true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }

        private void orderSubmitBtn_Click(object sender, EventArgs e)
        {
            ep_order.Clear();

            if (!uint.TryParse(orderIdInput.Text, out var id) || id < 0)
            {
                ep_order.SetError(orderIdInput, "Invalid or negative value");
                return;
            }

            if (!float.TryParse(orderTotalInput.Text, out var total) || total < 0)
            {
                ep_order.SetError(orderTotalInput, "Invalid or negative value");
                return;
            }

            var model = viewModel.ToModel();

            if(originalOrder != null)
                orders.Remove(originalOrder);

            if(orders.Any(o => o.OrderId == model.OrderId))
            {
                MessageBox.Show("An order with this ID already exists.");
                return;
            }

            /// Save to in-memory list
            orders.Add(model);

            /// Save to database
            using (var db = new RestaurantContext())
            {
                var existingOrder = db.Orders.FirstOrDefault(o => o.OrderId == model.OrderId);
                if (existingOrder != null)
                {
                    existingOrder.orderTotal = model.orderTotal;
                    db.SaveChanges();
                }
                else
                {
                    db.Orders.Add(model);
                    db.SaveChanges();
                }
            }

            this.Close();
        }
    }
}
