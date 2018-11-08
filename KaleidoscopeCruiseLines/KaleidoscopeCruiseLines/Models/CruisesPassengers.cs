namespace KaleidoscopeCruiseLines
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cruises.Passengers")]
    public partial class CruisesPassengers
    {
        [Key]
        public int passenger_id { get; set; }

        public int booking_id { get; set; }

        public virtual Booking Booking { get; set; }
    }
}
