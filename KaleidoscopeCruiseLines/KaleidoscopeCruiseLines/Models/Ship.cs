namespace KaleidoscopeCruiseLines
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ships.Ships")]
    public partial class Ship
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        public int length { get; set; }

        public int beam { get; set; }

        public int tons { get; set; }

        public int passengers { get; set; }

        public int crew { get; set; }
    }
}
