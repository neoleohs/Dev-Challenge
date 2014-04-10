using System.Collections.Generic;
using Data.Interfaces.Models;

namespace DevChallenge.Services
{
    public interface ISearchService
    {
        List<Title> GetTitles(string name);
    }
}
