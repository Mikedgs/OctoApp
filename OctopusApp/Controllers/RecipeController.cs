using System.Web.Mvc;
using OctopusApp.Models;
using OctopusApp.Plumbing;

namespace OctopusApp.Controllers
{
    public class RecipeController : Controller
    {
        private readonly Repository<OctopusRecipe> _repository = new Repository<OctopusRecipe>();
        private readonly RecipeRepositoryWrapper _recipeRepositoryWrapper = new RecipeRepositoryWrapper();
           
        [HttpGet]
        public ActionResult Index()
        {
            return View(_repository.GetAll());
        }

        [HttpGet]
        public ActionResult NewRecipe()
        {
            return View(new NewRecipeViewModel(new OctopusRecipe(), _repository.GetAll()));
        }

        [HttpPost]
        public ActionResult NewRecipe(NewRecipeViewModel recipeViewModel)
        {
            _recipeRepositoryWrapper.SaveRecipe(recipeViewModel.OctopusRecipe, recipeViewModel.ListOfIds);
            return RedirectToAction("Index");
        }
    }
}