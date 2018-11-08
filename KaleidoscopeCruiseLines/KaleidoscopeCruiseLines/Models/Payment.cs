namespace KaleidoscopeCruiseLines
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cruises.Payments")]
    public partial class Payment
    {
        [Key]
        public int payment_id { get; set; }

        public int passenger_id { get; set; }

        public DateTime date_time { get; set; }

        public decimal amount { get; set; }

        [Required]
        [StringLength(4)]
        public string card_number { get; set; }

        public virtual Passengers Passengers1 { get; set; }
    }
}
