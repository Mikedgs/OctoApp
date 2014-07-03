using System.Collections.Generic;
using OctopusApp.Plumbing;

namespace OctopusApp.Models
{
    public class NewRecipeViewModel
    {
        public IEnumerable<OctopusRecipe> OctopusRecipes { get; set; }
        public OctopusRecipe OctopusRecipe { get; set; }
        public List<int> ListOfIds { get; set; }
    }
}