using Data.Interfaces.Models;
using System.Collections.Generic;

namespace Data.Interfaces.Repositories
{
    public interface ITitleRepository
    {
        List<Title> GetTitles(string name);
    }
}
