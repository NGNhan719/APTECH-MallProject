namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ScreenHall")]
    public partial class ScreenHall
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ScreenHall()
        {
            ShowTimes = new HashSet<ShowTime>();
        }

        public int Id { get; set; }

        [StringLength(100)]
        public string ScreenName { get; set; }

        public int? SeatQty { get; set; }

        public int? ServiceProviderId { get; set; }

        public virtual ServiceProvider ServiceProvider { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShowTime> ShowTimes { get; set; }
    }
}
