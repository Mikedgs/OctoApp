using System;
using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using OctopusApp.Models;
using OctopusApp.Plumbing;
using OctopusApp.Plumbing.Interfaces;

namespace OctopusAppTests.Models
{
    [TestFixture]
    class RecipeRepositoryWrapperTests : UnitTestBase<RecipeRepositoryWrapper>
    {
        [Test]
        public void prepare_recipe_inserts_current_datetime_before_returning()
        {
            // Arrange
            var componentRepoMock = GetMock<IRepository<DeploymentComponent>>();
            componentRepoMock.Setup(x => x.FindById(It.IsAny<int>()))
                .Returns(new DeploymentComponent());
            
            // Act
            var result = ClassUnderTest.PrepareRecipe(new OctopusRecipe(), new List<int>() { 1 });

            // Assert
            Assert.That(result.DateCreated.Minute, Is.EqualTo(DateTime.Now.Minute));
        }

        [Test]
        public void prepare_recipe_inserts_deployment_components_before_saving()
        {
            // Arrange
            var componentRepoMock = GetMock<IRepository<DeploymentComponent>>();
            componentRepoMock.Setup(x => x.FindById(It.IsAny<int>()))
                .Returns(new DeploymentComponent());

            // Act
            var result = ClassUnderTest.PrepareRecipe(new OctopusRecipe(), new List<int>() { 1 });

            // Assert
            Assert.That(result.DeploymentComponents.Count, Is.EqualTo(1));
        }
    }
}
