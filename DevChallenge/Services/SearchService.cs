using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Data.Interfaces.Models;
using Data.Interfaces.Repositories;

namespace DevChallenge.Services
{
    public class SearchService : ISearchService
    {
        private readonly ITitleRepository _titleRepository;

        public SearchService(ITitleRepository titleRepository)
        {
            _titleRepository = titleRepository;
        }

        public List<Title> GetTitles(string name)
        {
            return _titleRepository.GetTitles(name);
        }
    }
}