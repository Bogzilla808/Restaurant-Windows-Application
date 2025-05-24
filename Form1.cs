using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Drawing.Printing;
using System.Reflection;
using System.Data.SQLite;

namespace _1076_Radu_Bogdan_PROJ
{
    public partial class Form1 : Form
    {
        private List<Waiter> waiters = new List<Waiter>();
        private List<Order> orders = new List<Order>();
        private List<Reservation> reservations = new List<Reservation>();

        private PrintDocument printDocument = new PrintDocument();
        private string printContent = ""; // Will store the report text
        private int currentPrintLineIndex = 0;
        private string[] printLines; // Lines to print

        /// Drag and drop variables
        private bool isDragging = false;
        private Point dragStartPoint = Point.Empty;

        public Form1()
        {
            InitializeComponent();

            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);

            panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(panel1);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (var db = new RestaurantContext())
            {
                var reservations = db.Reservations.ToList();
                db.Reservations.RemoveRange(reservations);

                // 2. Delete Orders
                var orders = db.Orders.ToList();
                db.Orders.RemoveRange(orders);

                // 3. Delete Waiters
                var waiters = db.Waiters.ToList();
                db.Waiters.RemoveRange(waiters);

                db.SaveChanges();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.Clear(Color.White);

            if (waiters.Count == 0) return;

            Dictionary<int, int> resPerWaiter = new Dictionary<int, int>();

            foreach (var waiter in waiters)
            {
                resPerWaiter[(int)waiter.WaiterId] = 0;
            }

            foreach (var res in reservations)
            {
                if (resPerWaiter.ContainsKey(res.WaiterId))
                    resPerWaiter[res.WaiterId]++;
            }

            // Chart drawing area
            int chartWidth = panel1.Width - 40;
            int chartHeight = panel1.Height - 40;
            int maxBarHeight = chartHeight - 40;

            // Determine max value for scaling
            int maxCount = resPerWaiter.Values.Count > 0 ? resPerWaiter.Values.Max() : 1;
            int barWidth = (chartWidth - 20) / waiters.Count;

            Font font = new Font("Arial", 8);
            Brush barBrush = Brushes.SteelBlue;
            Pen axisPen = Pens.Black;

            // Draw axes
            g.DrawLine(axisPen, 30, 10, 30, chartHeight);
            g.DrawLine(axisPen, 30, chartHeight, chartWidth + 10, chartHeight);

            int x = 40;
            foreach (var waiter in waiters)
            {
                int count = resPerWaiter[(int)waiter.WaiterId];
                int barHeight = (int)((float)count / maxCount * maxBarHeight);

                g.FillRectangle(barBrush, x, chartHeight - barHeight, barWidth - 10, barHeight);
                g.DrawString(waiter.WaiterName, font, Brushes.Black, x, chartHeight + 5);
                g.DrawString(count.ToString(), font, Brushes.Black, x, chartHeight - barHeight - 15);

                x += barWidth;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.MouseDown += PanelChart_MouseDown;
            panel1.MouseMove += PanelChart_MouseMove;
            panel1.MouseUp += PanelChart_MouseUp;

            DatabaseHelper.InitializeDatabase();
            waiters = DatabaseHelper.GetWaiters();
            orders = DatabaseHelper.GetOrders();
            reservations = DatabaseHelper.GetReservations();

            RefreshWaiterList();
            RefreshOrderList();
            RefreshResList();
        }

        private void PanelChart_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                dragStartPoint = e.Location;
                panel1.Cursor = Cursors.SizeAll;
            }
        }

        private void PanelChart_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                // Calculate new position
                Point newLocation = panel1.Location;
                newLocation.X += e.X - dragStartPoint.X;
                newLocation.Y += e.Y - dragStartPoint.Y;

                // Keep panel within bounds of the form
                newLocation.X = Math.Max(0, Math.Min(this.ClientSize.Width - panel1.Width, newLocation.X));
                newLocation.Y = Math.Max(0, Math.Min(this.ClientSize.Height - panel1.Height, newLocation.Y));

                panel1.Location = newLocation;
            }
        }

        private void PanelChart_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            panel1.Cursor = Cursors.Default;
        }

        private void addWaiterBtn_Click(object sender, EventArgs e)
        {
            var waiterForm = new WaiterForm();
            waiterForm.FormClosed += (s, args) =>
            {
                using (var db = new RestaurantContext())
                {
                    waiters = db.Waiters.ToList();
                    RefreshWaiterList();
                }
            };
            waiterForm.Show();  
        }

        private void RefreshWaiterList()
        {
            panel1.Invalidate();
            //waiters.Sort();
            lstWaiters.Items.Clear();
            foreach (var waiter in waiters)
            {
                ListViewItem lvItem = new ListViewItem(waiter.WaiterId.ToString());
                lvItem.SubItems.Add(waiter.WaiterName);

                lstWaiters.Items.Add(lvItem);
            }
        }

        private void RefreshOrderList()
        {
            //orders.Sort();
            lstOrders.Items.Clear();
            foreach(var order in orders)
            {
                ListViewItem lvItem = new ListViewItem(order.OrderId.ToString());
                lvItem.SubItems.Add(order.orderTotal.ToString());
                lstOrders.Items.Add(lvItem);
            }
        }

        private void RefreshResList()
        {
            panel1.Invalidate();
            lstReservations.Items.Clear();
            foreach(var res in reservations)
            {
                ListViewItem lvItem = new ListViewItem(res.ReservationId.ToString());
                lvItem.SubItems.Add(res.NoPersons.ToString());
                lvItem.SubItems.Add(res.OrderId.ToString());
                lvItem.SubItems.Add(res.WaiterId.ToString());

                lstReservations.Items.Add(lvItem);
            }
        }

        private void lstWaiters_DoubleClick(object sender, EventArgs e)
        {
            if(lstWaiters.SelectedItems.Count == 0) return;
            int index = lstWaiters.SelectedItems[0].Index;

            if (index >= 0 && index < lstWaiters.Items.Count)
            {
                Waiter selectedWaiter = waiters[index];
                var editForm = new WaiterForm(selectedWaiter);
                editForm.FormClosed += (s, args) =>
                {
                    using (var db = new RestaurantContext())
                    {
                        waiters = db.Waiters.ToList();
                        RefreshWaiterList();
                    }
                };
                editForm.Show();
            } 
        }

        private void lstOrders_DoubleClick(object sender, EventArgs e)
        {
            if (lstOrders.SelectedItems.Count == 0) return;
            int index = lstOrders.SelectedItems[0].Index;
            Order selectedOrder = orders[index];

            var editForm = new OrderForm(orders, selectedOrder);
            editForm.FormClosed += (s, args) => RefreshOrderList();
            editForm.Show();
        }

        private void lstReservations_DoubleClick(object sender, EventArgs e)
        {
            if (lstReservations.SelectedItems.Count == 0) return;
            int index = lstReservations.SelectedItems[0].Index;
            Reservation selectedReservation = reservations[index];

            var editForm = new ReservationForm(reservations, orders, waiters, selectedReservation);
            editForm.FormClosed += (s, args) => RefreshResList();
            editForm.Show();
        }

        private void deleteWaiterBtn_Click(object sender, EventArgs e)
        {
            panel1.Invalidate();
            if (lstWaiters.SelectedItems.Count == 0) return;
            var i = lstWaiters.SelectedItems[0].Index;

            var waiterToDelete = waiters[i];

            var confirm = MessageBox.Show(
                $"Are you sure you want to delete waiter: {waiterToDelete.WaiterName}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    DatabaseHelper.DeleteWaiter(waiterToDelete.WaiterId);
                    waiters.RemoveAt(i);
                    RefreshWaiterList();
                }
                catch (SQLiteException ex) when (ex.ResultCode == SQLiteErrorCode.Constraint) 
                {
                        MessageBox.Show("Cannot delete this waiter because it is assigned to a reservation.");
                }
            }
        }

        private void LoadWaiters()
        {
            lstWaiters.Items.Clear();
            var waiters = DatabaseHelper.GetWaiters();

            foreach (var waiter in waiters)
            {
                var item = new ListViewItem(waiter.WaiterId.ToString());
                item.SubItems.Add(waiter.WaiterName);
                lstWaiters.Items.Add(item);
            }
        }

        private void deleteOrderBtn_Click(object sender, EventArgs e)
        {
            if (lstOrders.SelectedItems.Count == 0) return;
            var i = lstOrders.SelectedItems[0].Index;
            var orderToDelete = orders[i];

            var confirm = MessageBox.Show(
            $"Are you sure you want to delete Order ID: {orderToDelete.OrderId}?",
            "Confirm Delete",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    DatabaseHelper.DeleteOrder(orderToDelete.OrderId); // ✅ Delete from DB
                    orders.RemoveAt(i);                                // ✅ Remove from memory
                    RefreshOrderList();                                // ✅ Refresh list
                }
                catch (SQLiteException ex) when (ex.ResultCode == SQLiteErrorCode.Constraint)
                {
                    MessageBox.Show("Cannot delete this order because it is assigned to a reservation.");
                }
            }
        }

        private void deleteReservationBtn_Click(object sender, EventArgs e)
        {
            panel1.Invalidate();
            if (lstReservations.SelectedItems.Count == 0) { return; }
            var i = lstReservations.SelectedItems[0].Index;
            var reservationToDelete = reservations[i];

            var confirm = MessageBox.Show(
               $"Are you sure you want to delete Reservation ID: {reservationToDelete.ReservationId}?",
               "Confirm Delete",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    DatabaseHelper.DeleteReservation(reservationToDelete.ReservationId); // ✅ Remove from DB
                    reservations.RemoveAt(i);                                            // ✅ Remove from memory
                    RefreshResList();                                            // ✅ Redraw the UI list
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Failed to delete reservation: " + ex.Message);
                }
            }
        }

        /// Serialize to XML
        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "XML files (*.xml)|*.xml";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        RestaurantData data = new RestaurantData()
                        {
                            Orders = orders,
                            Waiters = waiters,
                            Reservations = reservations
                        };

                        XmlSerializer serializer = new XmlSerializer(typeof(RestaurantData));
                        using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                        {
                            serializer.Serialize(fs, data);
                        }
                        MessageBox.Show("Data serialized successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error during serialization: " + ex.Message);
                    }
                }
            }    
        }

        ///  Deserialize from XML
        private void xMLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "XML files (*.xml)|*.xml";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XmlSerializer serializer = new XmlSerializer (typeof(RestaurantData));
                        using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open))
                        {
                            RestaurantData data = (RestaurantData)serializer.Deserialize(fs);
                            orders = data.Orders ?? new List<Order>();
                            waiters = data.Waiters ?? new List<Waiter>();
                            reservations = data.Reservations ?? new List<Reservation>();
                        }

                        // Clear existing data from DB (DELETE RESERVATIONS FIRST DUE TO CONSTRAINTS)
                        foreach (var res in DatabaseHelper.GetReservations())
                            DatabaseHelper.DeleteReservation(res.ReservationId);

                        foreach (var order in DatabaseHelper.GetOrders())
                            DatabaseHelper.DeleteOrder(order.OrderId);

                        foreach (var waiter in DatabaseHelper.GetWaiters())
                            DatabaseHelper.DeleteWaiter(waiter.WaiterId);

                        // Insert deserialized data into DB
                        foreach (var waiter in waiters)
                            DatabaseHelper.AddWaiter(waiter);

                        foreach (var order in orders)
                            DatabaseHelper.AddOrder(order);

                        foreach (var reservation in reservations)
                            DatabaseHelper.AddReservation(reservation);

                        MessageBox.Show("Deserialization and DB update successfull");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            RefreshResList();
            RefreshWaiterList();
            RefreshOrderList();
        }

        private void addOrderBtn_Click(object sender, EventArgs e)
        {
            var orderForm = new OrderForm(orders);
            orderForm.FormClosed += (s, args) => RefreshOrderList();
            orderForm.Show();
        }

        private void addReservationBtn_Click(object sender, EventArgs e)
        {
            var reservationForm = new ReservationForm(reservations, orders, waiters);
            reservationForm.FormClosed += (s, args) => { 
                RefreshResList(); 
                reservations = DatabaseHelper.GetReservations(); 
            };
            reservationForm.Show();
        }

        private void txtReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt";
                saveFileDialog.Title = "Report";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                        {
                            var sb = new StringBuilder();

                            sb.AppendLine("=== Waiters ===");
                            foreach (var waiter in waiters)
                                sb.AppendLine($"ID: {waiter.WaiterId}, Name: {waiter.WaiterName}");

                            sb.AppendLine("\n=== Orders ===");
                            foreach (var order in orders)
                                sb.AppendLine($"ID: {order.OrderId}, Total: {order.orderTotal}");

                            sb.AppendLine("\n=== Reservations ===");
                            foreach (var res in reservations)
                                sb.AppendLine($"ID: {res.ReservationId}, Persons: {res.NoPersons}, Order ID: {res.OrderId}, Waiter ID: {res.WaiterId}");

                            writer.Write(sb.ToString());
                            printContent = sb.ToString(); // Save for printing
                        }

                        MessageBox.Show("Report exported successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error exporting report: " + ex.Message);
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Current Time: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshWaiterList();
            RefreshOrderList();
            RefreshResList();
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(printContent))
            {
                MessageBox.Show("Nothing to print. Try exporting the txt report first!!!");
                return;
            }

            printLines = printContent.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            currentPrintLineIndex = 0;

            printDocument.PrintPage -= PrintDocument_PrintPage; // Avoid duplicate handlers
            printDocument.PrintPage += PrintDocument_PrintPage;

            PrintPreviewDialog previewDialog = new PrintPreviewDialog
            {
                Document = printDocument,
                Width = 800,
                Height = 600
            };
            previewDialog.ShowDialog();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 10);
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int lineHeight = (int)font.GetHeight(e.Graphics);

            int linesPerPage = e.MarginBounds.Height / lineHeight;
            int count = 0;

            while (count < linesPerPage && currentPrintLineIndex < printLines.Length)
            {
                string line = printLines[currentPrintLineIndex++];
                e.Graphics.DrawString(line, font, Brushes.Black, leftMargin, topMargin + count * lineHeight);
                count++;
            }

            e.HasMorePages = currentPrintLineIndex < printLines.Length;
        }
    }
}
