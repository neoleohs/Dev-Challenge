using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.EntityFramework.Entities
{
    [Table("Title", Schema = "dbo")]
    public class Title
    {
        [Key]
        public int TitleId { get; set; }

        [MaxLength(255), Column(TypeName = "nvarchar")]
        public string TitleName { get; set; }

        [MaxLength(255), Column(TypeName = "nvarchar")]
        public string TitleNameSortable { get; set; }

        public int? TitleTypeId { get; set; }
        public int? ReleaseYear { get; set; }

        public DateTime?  ProcessedDateTimeUTC { get; set; }
    }
}

