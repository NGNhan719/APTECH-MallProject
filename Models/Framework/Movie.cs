namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Movie")]
    public partial class Movie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Movie()
        {
            ShowTimes = new HashSet<ShowTime>();
        }

        public int Id { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public int? RunningTime { get; set; }

        [Column(TypeName = "text")]
        public string Introduction { get; set; }

        [StringLength(2083)]
        public string Trailer { get; set; }

        public int? Rate { get; set; }

        public int? CommonKeyId { get; set; }

        public virtual CommonKey CommonKey { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShowTime> ShowTimes { get; set; }
    }
}
