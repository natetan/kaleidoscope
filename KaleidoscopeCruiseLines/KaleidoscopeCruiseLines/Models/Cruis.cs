namespace KaleidoscopeCruiseLines
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cruises.Cruises")]
    public partial class Cruis
    {
        [Key]
        public int cruise_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime start_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime end_date { get; set; }

        public int ship_id { get; set; }
    }
}
