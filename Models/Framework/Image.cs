namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Image")]
    public partial class Image
    {
        public int Id { get; set; }

        [StringLength(2048)]
        public string Thumbnail { get; set; }

        public int? CommonKeyId { get; set; }

        public virtual CommonKey CommonKey { get; set; }
    }
}
