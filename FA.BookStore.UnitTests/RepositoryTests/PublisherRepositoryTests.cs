using FA.BookStore.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.BookStore.UnitTests.RepositoryTests
{


    [TestFixture]
    public class PublisherRepositoryTests : BaseTest
    {
        public PublisherRepositoryTests() : base()
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
            var result = publisherRepository.GetAll();


            // Assert
            Assert.That(result.Count, Is.EqualTo(3));
        }

        [Test]
        public void Find_WhenCalled_ReturnObject()
        {
            var result = publisherRepository.Find(1);

            Assert.IsNotNull(result);
        }


        [Test]
        public void AddPublisher_WhenCalled_ReturnObject()
        {
            // Arrange
            var newPublisher = new Publisher { PubId = 4, Name = "Publisher 4", Description = "Description 4" };

            // Act
            publisherRepository.Create(newPublisher);

            // Assert
            var result = publisherRepository.GetAll();
            Assert.That(result.Count, Is.EqualTo(4));
            //  Assert.That(result.Last().Name, Is.EqualTo("Publisher 4"));
        }
        [Test]
        public void UpdatePublisher_WhenCalled_UpdatePublisherInDatabase()
        {
            // Arrange
            var publisherToUpdate = publisherRepository.Find(1);
            publisherToUpdate.Name = "Updated Publisher";

            // Act
            publisherRepository.Update(publisherToUpdate);

            // Assert
            var result = publisherRepository.Find(1);
            Assert.That(result.Name, Is.EqualTo("Updated Publisher"));
        }
        [Test]
        public void DeletePublisher_WhenCalled_RemovePublisherFromDatabase()
        {
            // Arrange
            var publisherToDelete = publisherRepository.Find(3);

            // Act
            publisherRepository.Delete(publisherToDelete);

            // Assert
            var result = publisherRepository.GetAll();
            Assert.That(result.Count, Is.EqualTo(2));
            // Assert.That(result.Any(c => c.CateId == 3), Is.False);
        }
    }

}
