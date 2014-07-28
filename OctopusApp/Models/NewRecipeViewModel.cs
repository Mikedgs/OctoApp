using System.Collections.Generic;
using OctopusApp.Plumbing;

namespace OctopusApp.Models
{
    public class NewRecipeViewModel
    {
        public NewRecipeViewModel()
        {
            Errors = new List<string>();
            ListOfIds = new List<int>();
        }

        public NewRecipeViewModel(OctopusRecipe octopusRecipe, IEnumerable<OctopusRecipe> octopusRecipes)
        {
            OctopusRecipe = octopusRecipe;
            OctopusRecipes = octopusRecipes;
            Errors = new List<string>();
        }

        public IEnumerable<OctopusRecipe> OctopusRecipes { get; set; }
        public OctopusRecipe OctopusRecipe { get; set; }
        public List<int> ListOfIds { get; set; }
        public List<string> Errors { get; set; }
    }
}