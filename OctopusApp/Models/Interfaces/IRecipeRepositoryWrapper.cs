using System.Collections.Generic;
using OctopusApp.Plumbing;

namespace OctopusApp.Models.Interfaces
{
    public interface IRecipeRepositoryWrapper
    {
        void SaveRecipe(OctopusRecipe recipe, List<int> listOfComponentIds);
        IEnumerable<DeploymentComponent> GetComponentsById(List<int> listOfIds);
        OctopusRecipe PrepareRecipe(OctopusRecipe recipe, List<int> listOfComponentIds);
    }
}