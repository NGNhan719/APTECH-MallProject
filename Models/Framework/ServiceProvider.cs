namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ServiceProvider")]
    public partial class ServiceProvider
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ServiceProvider()
        {
            ScreenHalls = new HashSet<ScreenHall>();
        }

        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(10)]
        public string Floor { get; set; }

        [StringLength(20)]
        public string Tel { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }

        public int? ServiceId { get; set; }

        public int? CommonKeyId { get; set; }

        public virtual CommonKey CommonKey { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ScreenHall> ScreenHalls { get; set; }

        public virtual Service Service { get; set; }
    }
}
