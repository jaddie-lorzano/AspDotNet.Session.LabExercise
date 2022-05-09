using Microsoft.AspNetCore.Mvc;
using ToyUniverse.Data.Data;
using ToyUniverse.Web.Services;

namespace ToyUniverse.Web.Controllers
{
    public class ToyController : Controller
    {
        private readonly IToyService toyService;
        private readonly IUnitOfWork unitOfWork;
        public ToyController(IToyService toyService, IUnitOfWork unitOfWork)
        {
            this.toyService = toyService;
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var allToys = toyService.GetToyPage(1, 10);
            return View(allToys);
        }

        [HttpPost]
        public IActionResult Index(int currentPageIndex, int pageSize)
        {
            var allToys = toyService.GetToyPage(currentPageIndex, pageSize);
            return View(allToys);
        }

        public IActionResult Details(string id)
        {
            var toy = unitOfWork.ToyRepository.FindByPrimaryKey(id);
            ViewData["Toy"] = toy;
            return View();
        }
    }
}
