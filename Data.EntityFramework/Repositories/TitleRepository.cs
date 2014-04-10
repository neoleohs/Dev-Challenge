using System;
using System.Collections.Generic;
using System.Linq;
using Data.Interfaces.Models;
using Data.Interfaces.Repositories;
using Data.EntityFramework.Context;

namespace Data.EntityFramework.Repositories
{
    public class TitleRepository : BaseRepository<TitlesContext>, ITitleRepository
    {
        public TitleRepository(TitlesContext context)
            : base(context)
        {

        }

        public List<Title> GetTitles(string name)
        {
            var newModels = new List<Entities.Title>();

            var titles = (from title in Context.Title
                         where title.TitleName.Contains(name)
                         select title).ToList();
            
            return titles.Select(t => t.ToDomainModel()).ToList();
        }
    }

    internal static class ModelExtensions
    {
        public static Title ToDomainModel(this Entities.Title title)
        {
            if (title == null)
                return null; 

            return new Title()
            {
                TitleId = title.TitleId,
                TitleName = title.TitleName,
                TitleTypeId = title.TitleTypeId ?? 0,
                TitleNameSortable = title.TitleNameSortable,
                ReleaseYear = title.ReleaseYear ?? 0,
                ProcessedDateTimeUTC = title.ProcessedDateTimeUTC ?? DateTime.MinValue,
            };
        }
    }
}
