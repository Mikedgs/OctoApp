using System;
using System.Collections.Generic;
using System.Linq;
using OctopusApp.Plumbing;

namespace OctopusApp.Models
{
    public class RecipeRepositoryWrapper
    {
        private readonly Repository<DeploymentComponent> _componentRepository = new Repository<DeploymentComponent>();
        private readonly Repository<OctopusRecipe> _recipeRepository = new Repository<OctopusRecipe>(); 

        public void SaveRecipe(OctopusRecipe recipe, List<int> listOfComponentIds)
        {
            recipe.DateCreated = DateTime.Now;
            foreach (var component in GetComponentsById(listOfComponentIds))
            {
                recipe.DeploymentComponents.Add(component);
            }
            _recipeRepository.Add(recipe);
            _recipeRepository.SaveChanges();
        }

        public IEnumerable<DeploymentComponent> GetComponentsById(List<int> listOfIds)
        {
            return listOfIds.Select(id => _componentRepository.FindById(id)).ToList();
        }
    }
}