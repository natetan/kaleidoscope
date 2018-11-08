namespace KaleidoscopeCruiseLines
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Passengers.Passengers")]
    public partial class Passengers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Passengers()
        {
            Bookings = new HashSet<Booking>();
            Payments = new HashSet<Payment>();
        }

        [Key]
        public int passenger_id { get; set; }

        [Required]
        [StringLength(50)]
        public string lastname { get; set; }

        [Required]
        [StringLength(50)]
        public string firstname { get; set; }

        [Column(TypeName = "date")]
        public DateTime? birthdate { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(50)]
        public string password { get; set; }

        [StringLength(50)]
        public string street1 { get; set; }

        [StringLength(50)]
        public string street2 { get; set; }

        [StringLength(50)]
        public string city { get; set; }

        [StringLength(50)]
        public string state_province { get; set; }

        [StringLength(50)]
        public string postal_code { get; set; }

        [StringLength(2)]
        public string country_code { get; set; }

        [StringLength(50)]
        public string confirmation { get; set; }

        public int? guardian_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Bookings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
