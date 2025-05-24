using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1076_Radu_Bogdan_PROJ
{
    public static class DatabaseHelper
    {
        private static readonly string connectionString = "Data Source=restaurant.db;Version=3;";

        public static void InitializeDatabase()
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string createWaiterTable = @"
                CREATE TABLE IF NOT EXISTS Waiters (
                    WaiterId INTEGER PRIMARY KEY,
                    WaiterName TEXT NOT NULL
                );";

                string createOrderTable = @"
                CREATE TABLE IF NOT EXISTS Orders (
                    OrderId INTEGER PRIMARY KEY,
                    OrderTotal REAL NOT NULL
                );";

                string createReservationTable = @"
                CREATE TABLE IF NOT EXISTS Reservations (
                    ReservationId INTEGER PRIMARY KEY AUTOINCREMENT,
                    NoPersons INTEGER NOT NULL CHECK(noPersons >= 1 AND noPersons <= 100),
                    OrderId INTEGER NOT NULL,
                    WaiterId INTEGER NOT NULL,
                    FOREIGN KEY(OrderId) REFERENCES Orders(OrderId) ON DELETE RESTRICT,
                    FOREIGN KEY(WaiterId) REFERENCES Waiters(WaiterId) ON DELETE RESTRICT
                );";

                using (var cmd = new SQLiteCommand(createWaiterTable, conn))
                {
                    cmd.ExecuteNonQuery();
                }

                using (var cmd = new SQLiteCommand(createOrderTable, conn))
                {
                    cmd.ExecuteNonQuery();
                }

                using (var cmd = new SQLiteCommand(createReservationTable, conn))
                    cmd.ExecuteNonQuery();
            }
        }

        // CRUD for Waiter
        public static List<Waiter> GetWaiters()
        {
            var waiters = new List<Waiter>();
            using (var conn = GetOpenConnection())
            {
                string query = "SELECT * FROM Waiters";
                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        waiters.Add(new Waiter
                        {
                            WaiterId = reader.GetInt32(0),
                            WaiterName = reader.GetString(1)
                        });
                    }
                }
            }
            return waiters;
        }

        public static void AddWaiter(Waiter waiter)
        {
            using (var conn = GetOpenConnection())
            {
                string query = "INSERT INTO Waiters (WaiterName) VALUES (@name)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", waiter.WaiterName);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateWaiter(Waiter waiter)
        {
            using (var conn = GetOpenConnection())
            {
                string query = "UPDATE Waiters SET WaiterName = @name WHERE WaiterId = @id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", waiter.WaiterName);
                    cmd.Parameters.AddWithValue("@id", waiter.WaiterId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteWaiter(int id)
        {
            using (var conn = GetOpenConnection())
            {
                string query = "DELETE FROM Waiters WHERE WaiterId = @id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // CRUD for Order
        public static List<Order> GetOrders()
        {
            var orders = new List<Order>();
            using (var conn = GetOpenConnection())
            {
                string query = "SELECT * FROM Orders";
                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        orders.Add(new Order
                        {
                            OrderId = reader.GetInt32(0),
                            orderTotal = reader.GetFloat(1)
                        });
                    }
                }
            }
            return orders;
        }

        public static void AddOrder(Order order)
        {
            using (var conn = GetOpenConnection())
            {
                string query = "INSERT INTO Orders (OrderTotal) VALUES (@total)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@total", order.orderTotal);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateOrder(Order order)
        {
            using (var conn = GetOpenConnection())
            {
                string query = "UPDATE Orders SET OrderTotal = @total WHERE OrderId = @id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@total", order.orderTotal);
                    cmd.Parameters.AddWithValue("@id", order.OrderId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteOrder(int id)
        {
            using (var conn = GetOpenConnection())
            {
                string query = "DELETE FROM Orders WHERE OrderId = @id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // CRUD for reservations
        public static void AddReservation(Reservation reservation)
        {
            using (var db = new RestaurantContext())
            {
                //var waiterExists = DatabaseHelper.GetWaiters().Any(w => w.WaiterId == reservation.waiterId);
                //var orderExists = DatabaseHelper.GetOrders().Any(o => o.orderId == reservation.orderId);

                var existingWaiter = db.Waiters.Find(reservation.WaiterId);
                var existingOrder = db.Orders.Find(reservation.OrderId);

                if (existingWaiter == null || existingOrder == null)
                {
                    throw new Exception("Invalid foreign key: Waiter or Order does not exist.");
                }

                db.Reservations.Add(reservation);
                db.SaveChanges();
            }
        }

        public static void DeleteReservation(int id)
        {
            using (var conn = GetOpenConnection())
            {
                string query = "DELETE FROM Reservations WHERE ReservationId = @id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Reservation> GetReservations()
        {
            var reservations = new List<Reservation>();

            using (var conn = GetOpenConnection())
            {
                string query = "SELECT ReservationId, NoPersons, OrderId, WaiterId FROM Reservations";

                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var reservation = new Reservation
                        {
                            ReservationId = reader.GetInt32(0),
                            NoPersons = reader.GetInt32(1),
                            OrderId = reader.GetInt32(2),
                            WaiterId = reader.GetInt32(3),
                            // Order and Waiter will be populated below
                        };

                        // Fetch related Order and Waiter objects (optional)
                        reservation.Order = GetOrders().FirstOrDefault(o => o.OrderId == reservation.OrderId);
                        reservation.Waiter = GetWaiters().FirstOrDefault(w => w.WaiterId == reservation.WaiterId);

                        reservations.Add(reservation);
                    }
                }
            }

            return reservations;
        }

        public static void UpdateReservation(Reservation updatedReservation)
        {
            using (var db = new RestaurantContext())
            {
                var existingReservation = db.Reservations.Find(updatedReservation.ReservationId);
                if (existingReservation == null)
                {
                    throw new Exception("Reservation not found.");
                }

                // Update the fields
                existingReservation.NoPersons = updatedReservation.NoPersons;
                existingReservation.OrderId = updatedReservation.OrderId;
                existingReservation.WaiterId = updatedReservation.WaiterId;

                db.SaveChanges();
            }
        }

        private static SQLiteConnection GetOpenConnection()
        {
            var conn = new SQLiteConnection(connectionString);
            conn.Open();

            using (var cmd = new SQLiteCommand("PRAGMA foreign_keys = ON;", conn))
            {
                cmd.ExecuteNonQuery();
            }

            return conn;
        }
    }
}
