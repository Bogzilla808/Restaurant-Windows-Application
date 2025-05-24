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
    public partial class WaiterForm : Form
    {
        private List<Waiter> waiters = new List<Waiter>();
        private Waiter editingWaiter;

        private WaiterViewModel viewModel;
        private Waiter originalWaiter;

        public WaiterForm(Waiter waiterToEdit = null)
        {
            InitializeComponent();

            if (waiterToEdit != null)
            {
                originalWaiter = waiterToEdit;
                viewModel = new WaiterViewModel(waiterToEdit);

                submitWaiterBtn.Text = "Update Waiter";
            }
            else
            {
                viewModel = new WaiterViewModel();
            }

            waiterNameInput.DataBindings.Add("Text", viewModel, nameof(viewModel.WaiterName),
                true, DataSourceUpdateMode.OnPropertyChanged);
            waiterIdInput.DataBindings.Add("Text", viewModel, nameof(viewModel.WaiterId), true,
                DataSourceUpdateMode.OnPropertyChanged);
        }

        private void WaiterForm_Load(object sender, EventArgs e)
        {
            waiterIdInput.ReadOnly = true;
        }

        private void submitWaiterBtn_Click(object sender, EventArgs e)
        {
            ep_waiter.Clear();

            if(viewModel.WaiterId < 0)
            {
                ep_waiter.SetError(waiterIdInput, "Invalid ID");
                return;
            }

            /// Save / Update the model
            var model = viewModel.ToModel();

            using (var db = new RestaurantContext())
            {
                var existing = db.Waiters.Find(model.WaiterId);

                if (existing != null)
                {
                    // Update
                    existing.WaiterName = model.WaiterName;
                    db.Entry(existing).State = System.Data.Entity.EntityState.Modified;
                }
                else
                {
                    // Insert
                    db.Waiters.Add(model);
                }

                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    var inner = ex.InnerException?.InnerException?.Message ?? ex.Message;
                    MessageBox.Show("Database error: " + inner);
                    return;
                }
            }
            this.Close();
        }
    }
}
