using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using OctopusApp.Controllers;
using OctopusApp.Models;
using OctopusApp.Models.Interfaces;
using OctopusApp.Plumbing;
using OctopusApp.Plumbing.Interfaces;

namespace OctopusAppTests.Controllers
{
    [TestFixture]
    internal class RecipeControllerTests_Index_Scenario : UnitTestBase<RecipeController>
    {
        [Test]
        public void index_action_queries_database_before_returning_view()
        {
            // Arrange
            var recipeRepositoryMock = GetMock<IRepository<OctopusRecipe>>();

            // Act
            ClassUnderTest.Index();

            // Assert
            recipeRepositoryMock.Verify(x => x.GetAll(), Times.Exactly(1));
        }

        [Test]
        public void index_action_returns_view_with_list_of_recipes()
        {
            // Arrange
            var recipeRepositoryMock = GetMock<IRepository<OctopusRecipe>>();
            recipeRepositoryMock.Setup(x => x.GetAll()).Returns(new List<OctopusRecipe>());

            // Act
            var result = ClassUnderTest.Index();

            // Assert
            Assert.IsInstanceOf(typeof (IEnumerable<OctopusRecipe>), result.Model);
        }
    }

    [TestFixture]
    internal class RecipeControllerTests_NewRecipe_Scenario : UnitTestBase<RecipeController>
    {
        [Test]
        public void newRecipe_action_queries_database_before_returning_view()
        {
            // Arrange
            var recipeRepositoryMock = GetMock<IRepository<OctopusRecipe>>();

            // Act
            ClassUnderTest.Index();

            // Assert
            recipeRepositoryMock.Verify(x => x.GetAll(), Times.Exactly(1));
        }

        [Test]
        public void newRecipe_action_returns_view_with_newRecipeViewModel_as_model()
        {
            // Arrange
            var recipeRepositoryMock = GetMock<IRepository<OctopusRecipe>>();
            recipeRepositoryMock.Setup(x => x.GetAll()).Returns(new List<OctopusRecipe>() {new OctopusRecipe()});

            // Act
            var result = ClassUnderTest.NewRecipe();

            // Assert
            Assert.IsInstanceOf(typeof (NewRecipeViewModel), result.Model);
        }
    }

    [TestFixture]
    internal class RecipeControllerTests_SaveRecipe_Scenario : UnitTestBase<RecipeController>
    {
        [Test]
        public void saveRecipe_action_calls_save_method_before_redirecting()
        {
            // Arrange
            var recipeRepositoryWrapperMock = GetMock<IRecipeRepositoryWrapper>();

            // Act
            ClassUnderTest.NewRecipe(new NewRecipeViewModel());

            // Assert
            recipeRepositoryWrapperMock.Verify(x=>x.SaveRecipe(It.IsAny<OctopusRecipe>(), It.IsAny<List<int>>()), Times.Exactly(1));
        }
    }
}
