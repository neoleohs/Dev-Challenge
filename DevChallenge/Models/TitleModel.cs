using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevChallenge.Models
{
    public class TitleModel
    {
        public List<Title> Titles { get; set; }
    }

    public class Title
    {
        public int TitleId { get; set; }
        public string TitleName { get; set; }
        public string TitleNameSortable { get; set; }
        public int TitleTypeId { get; set; }
        public int ReleaseYear { get; set; }
        public DateTime ProcessedDateTimeUTC { get; set; }
    }

    internal static class ModelExtensions
    {
        public static Title ToViewModel(this Data.Interfaces.Models.Title title)
        {
            if (title == null)
                return null;

            return new Title()
            {
                TitleId = title.TitleId,
                TitleName = title.TitleName,
                TitleTypeId = title.TitleTypeId,
                TitleNameSortable = title.TitleNameSortable,
                ReleaseYear = title.ReleaseYear,
                ProcessedDateTimeUTC = title.ProcessedDateTimeUTC,
            };
        }
    } 
}