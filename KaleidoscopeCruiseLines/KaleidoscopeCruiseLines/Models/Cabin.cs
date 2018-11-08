namespace KaleidoscopeCruiseLines
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ships.Cabins")]
    public partial class Cabin
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ship_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cabin_id { get; set; }

        public int type_id { get; set; }

        public bool balcony { get; set; }

        public bool suite { get; set; }

        public int passengers { get; set; }
    }
}
