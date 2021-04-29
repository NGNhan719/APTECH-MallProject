namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ShowTime")]
    public partial class ShowTime
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ShowTime()
        {
            Tickets = new HashSet<Ticket>();
        }

        public int Id { get; set; }

        public DateTime? Date { get; set; }

        public TimeSpan? StartHour { get; set; }

        public TimeSpan? EndHour { get; set; }

        public int? TotalTicket { get; set; }

        public int? MovieId { get; set; }

        public int? ScreenId { get; set; }

        public virtual Movie Movie { get; set; }

        public virtual ScreenHall ScreenHall { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
