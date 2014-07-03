using System;
using System.Collections.Generic;
using System.Linq;
using OctopusApp.Models.Interfaces;
using OctopusApp.Plumbing;
using OctopusApp.Plumbing.Interfaces;

namespace OctopusApp.Models
{
    public class RecipeRepositoryWrapper : IRecipeRepositoryWrapper
    {
        private readonly IRepository<DeploymentComponent> _componentRepository;
        private readonly IRepository<OctopusRecipe> _recipeRepository;

        public RecipeRepositoryWrapper(IRepository<DeploymentComponent> componentRepository,
            IRepository<OctopusRecipe> recipeRepository)
        {
            _componentRepository = componentRepository;
            _recipeRepository = recipeRepository;
        }

        public void SaveRecipe(OctopusRecipe recipe, List<int> listOfComponentIds)
        {
            _recipeRepository.Add(PrepareRecipe(recipe, listOfComponentIds));
            _recipeRepository.SaveChanges();
        }

        public IEnumerable<DeploymentComponent> GetComponentsById(List<int> listOfIds)
        {
            return listOfIds.Select(id => _componentRepository.FindById(id)).ToList();
        }

        public OctopusRecipe PrepareRecipe(OctopusRecipe recipe, List<int> listOfComponentIds)
        {
            recipe.DateCreated = DateTime.Now;
            if (listOfComponentIds.Count <= 0) return recipe;
            foreach (var component in GetComponentsById(listOfComponentIds))
            {
                recipe.DeploymentComponents.Add(component);
            }
            return recipe;
        }
    }
}