using System.Linq;
using System.Web.Mvc;
using DevChallenge.Models;

namespace DevChallenge.Controllers
{
    public class HomeController : Controller
    {
        private readonly Services.ISearchService _searchService;

        public HomeController(Services.ISearchService searchService)
        {
            _searchService = searchService;
        }

        [HttpPost]
        public ActionResult Index(string name)
        {
            var titles = _searchService.GetTitles(name);

            return View(new TitleModel { Titles = titles.Select(t => t.ToViewModel()).ToList() });
        }
    }
}