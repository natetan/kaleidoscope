namespace KaleidoscopeCruiseLines
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cruises.Bookings")]
    public partial class Booking
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Booking()
        {
            Passengers = new HashSet<CruisesPassengers>();
        }

        [Key]
        public int booking_id { get; set; }

        public int passenger_id { get; set; }

        public int? payment_id { get; set; }

        public decimal amount { get; set; }

        public virtual Passengers Passengers1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CruisesPassengers> Passengers { get; set; }
    }
}
