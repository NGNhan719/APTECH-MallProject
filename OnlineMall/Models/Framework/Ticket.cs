namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ticket")]
    public partial class Ticket
    {
        public int Id { get; set; }

        public double? Price { get; set; }

        public int? SeatNo { get; set; }

        public int? ShowTimeId { get; set; }

        public int? CreditCardId { get; set; }

        public virtual CreditCard CreditCard { get; set; }

        public virtual ShowTime ShowTime { get; set; }
    }
}
