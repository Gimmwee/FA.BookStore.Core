using FA.BookStore.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.BookStore.UnitTests.RepositoryTests
{
    [TestFixture]
    public class CategoryRepositoryTests : BaseTest
    {
        public CategoryRepositoryTests() : base()
        {

        }

        [OneTimeTearDown]
        public void Clean()
        {
            _context.Database.EnsureDeleted();
        }

        [Test]
        public void GetAll_WhenCalled_ReturnValue()
        {
            //Arrange

            //Act
            var result = categoryRepository.GetAll();


            // Assert
            Assert.That(result.Count, Is.EqualTo(3));
        }

        [Test]
        public void Find_WhenCalled_ReturnObject()
        {
            var result = categoryRepository.Find(1);

            Assert.IsNotNull(result);
        }

        [Test]
        public void AddCategory_WhenCalled_ReturnObject()
        {
            // Arrange
            var newCategory = new Category { CateId = 4 ,CateName = "Category 4" , Description = "Description 4" };

            // Act
            categoryRepository.Create(newCategory);

            // Assert
            var result = categoryRepository.GetAll();
            Assert.That(result.Count, Is.EqualTo(4));
            Assert.That(result.Last().CateName, Is.EqualTo("Category 4"));
        }
        [Test]
        public void UpdateCategory_WhenCalled_UpdateCategoryInDatabase()
        {
            // Arrange
            var categoryToUpdate = categoryRepository.Find(1);
            categoryToUpdate.CateName = "Updated Category";

            // Act
            categoryRepository.Update(categoryToUpdate);

            // Assert
            var result = categoryRepository.Find(1);
            Assert.That(result.CateName, Is.EqualTo("Updated Category"));
        }
        [Test]
        public void DeleteCategory_WhenCalled_RemoveCategoryFromDatabase()
        {
            // Arrange
            var categoryToDelete = categoryRepository.Find(3);

            // Act
            categoryRepository.Delete(categoryToDelete);

            // Assert
            var result = categoryRepository.GetAll();
            Assert.That(result.Count, Is.EqualTo(2));
          // Assert.That(result.Any(c => c.CateId == 3), Is.False);
        }
    }
}
