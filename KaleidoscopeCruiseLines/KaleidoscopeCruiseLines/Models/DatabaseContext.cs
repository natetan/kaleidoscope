namespace KaleidoscopeCruiseLines
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base("name=Entities")
        {
        }

        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Cruis> Cruises { get; set; }
        public virtual DbSet<CruisesPassengers> CruisePassengers { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Passengers> Passengers { get; set; }
        public virtual DbSet<Payments1> Payments1 { get; set; }
        public virtual DbSet<Cabin> Cabins { get; set; }
        public virtual DbSet<Ship> Ships { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>()
                .HasMany(e => e.Passengers)
                .WithRequired(e => e.Booking)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Passengers>()
                .HasMany(e => e.Bookings)
                .WithRequired(e => e.Passengers1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Passengers>()
                .HasMany(e => e.Payments)
                .WithRequired(e => e.Passengers1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ship>()
                .Property(e => e.name)
                .IsUnicode(false);
        }
    }
}
