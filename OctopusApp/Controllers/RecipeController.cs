using System;
using System.Web.Mvc;
using OctopusApp.Models;
using OctopusApp.Plumbing;

namespace OctopusApp.Controllers
{
    public class RecipeController : Controller
    {
        private readonly Repository<OctopusRecipe> _repository = new Repository<OctopusRecipe>();
        private readonly Repository<DeploymentComponent> _componentRepository = new Repository<DeploymentComponent>();
           
        [HttpGet]
        public ActionResult Index()
        {
            var listOfRecipes = _repository.GetAll();
            return View(listOfRecipes);
        }

        [HttpGet]
        public ActionResult NewRecipe()
        {
            var newRecipeViewModel = new NewRecipeViewModel()
            {
                OctopusRecipe = new OctopusRecipe(),
                OctopusRecipes = _repository.GetAll()
            };
            return View(newRecipeViewModel);
        }

        [HttpPost]
        public ActionResult NewRecipe(NewRecipeViewModel recipeViewModel)
        {
            recipeViewModel.OctopusRecipe.DateCreated = DateTime.Now;
            recipeViewModel.OctopusRecipe.RecipeId = "12345";

            foreach (var id in recipeViewModel.ListOfIds)
            {
                recipeViewModel.OctopusRecipe.DeploymentComponents.Add(_componentRepository.FindById(id));
            }

            _repository.Add(recipeViewModel.OctopusRecipe);
            _repository.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}