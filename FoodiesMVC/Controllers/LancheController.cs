using FoodiesMVC.Repositories.Interfaces;
using FoodiesMVC.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace FoodiesMVC.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _repository;

        public LancheController(ILancheRepository repository)
        {
            this._repository = repository;
        }
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult List()
        {
            var lancheList = new LancheListViewModel();

            lancheList.

            return View();
        }
    }
}
