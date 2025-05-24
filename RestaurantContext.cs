using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;

namespace _1076_Radu_Bogdan_PROJ
{
    public class RestaurantContext : DbContext
    {
        static RestaurantContext()
        {
            // Create the DB and tables if they don't exist
            Database.SetInitializer(new CreateDatabaseIfNotExists<RestaurantContext>());
        }

        public RestaurantContext() : base("name=RestaurantDb") {
            this.Database.ExecuteSqlCommand("PRAGMA foreign_keys=ON;");
        }

        public DbSet<Waiter> Waiters { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Reservation -> Waiter
            modelBuilder.Entity<Reservation>()
                .HasRequired(r => r.Waiter)
                .WithMany() 
                .HasForeignKey(r => r.WaiterId)
                .WillCascadeOnDelete(false);

            // Reservation -> Order
            modelBuilder.Entity<Reservation>()
                .HasRequired(r => r.Order)
                .WithMany() 
                .HasForeignKey(r => r.OrderId)
                .WillCascadeOnDelete(false);
        }
    }
}
