namespace KaleidoscopeCruiseLines
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Passengers.Payments")]
    public partial class Payments1
    {
        [Key]
        public int payment_id { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        [Required]
        [StringLength(50)]
        public string number { get; set; }

        [Column(TypeName = "date")]
        public DateTime expires { get; set; }

        public int ccv { get; set; }

        public bool preferred { get; set; }
    }
}
