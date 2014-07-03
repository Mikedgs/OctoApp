using System.Web.Mvc;
using OctopusApp.Models;
using OctopusApp.Models.Interfaces;
using OctopusApp.Plumbing;
using OctopusApp.Plumbing.Interfaces;

namespace OctopusApp.Controllers
{
    public class RecipeController : Controller
    {
        private readonly IRepository<OctopusRecipe> _recipeRepository;
        private readonly IRecipeRepositoryWrapper _recipeRepositoryWrapper;

        public RecipeController(IRepository<OctopusRecipe> recipeRepository, IRecipeRepositoryWrapper recipeRepositoryWrapper)
        {
            _recipeRepository = recipeRepository;
            _recipeRepositoryWrapper = recipeRepositoryWrapper;
        }

        [HttpGet]
        public ViewResult Index()
        {
            return View(_recipeRepository.GetAll());
        }

        [HttpGet]
        public ViewResult NewRecipe()
        {
            return View(new NewRecipeViewModel(new OctopusRecipe(), _recipeRepository.GetAll()));
        }

        [HttpPost]
        public ActionResult NewRecipe(NewRecipeViewModel recipeViewModel)
        {
            _recipeRepositoryWrapper.SaveRecipe(recipeViewModel.OctopusRecipe, recipeViewModel.ListOfIds);
            return RedirectToAction("Index");
        }
    }
}