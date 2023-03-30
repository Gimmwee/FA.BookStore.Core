using FA.BookStore.Core.Models;
using FA.BookStore.Core.Repository.ImplementRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.BookStore.UnitTests.RepositoryTests
{
    [TestFixture]
    public class CommentRepositoryTests : BaseTest
    {
        public CommentRepositoryTests() : base()
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
            var result = commentRepository.GetAll();


            // Assert
            Assert.That(result.Count, Is.EqualTo(3));
        }

        [Test]
        public void Find_WhenCalled_ReturnObject()
        {
            var result = commentRepository.Find(1);

            Assert.IsNotNull(result);
        }

        [Test]
        public void AddComment_WhenCalled_ReturnObject()
        {
            // Arrange
            var newComment = new Comment
            {

                CommentId = 4,
                BookId = 2,
                Content = "Content 4",
                CreatedDate = DateTime.Now,
                IsActive = true,
            };

            // Act
            commentRepository.Create(newComment);

            // Assert
            var result = commentRepository.GetAll();
            Assert.That(result.Count, Is.EqualTo(4));
            Assert.That(result.Last().Content, Is.EqualTo("Content 4"));
        }
        [Test]
        public void UpdateComment_WhenCalled_UpdateCommentInDatabase()
        {
            // Arrange
            var commentToUpdate = commentRepository.Find(2);
            commentToUpdate.Content = "Updated Content";

            // Act
            commentRepository.Update(commentToUpdate);

            // Assert
            var result = commentRepository.Find(2);
            Assert.That(result.Content, Is.EqualTo("Updated Content"));
        }
        [Test]
        public void DeleteComment_WhenCalled_RemoveCommentFromDatabase()
        {
            // Arrange
            var CommentToDelete = commentRepository.Find(3);

            // Act
            commentRepository.Delete(CommentToDelete);

            // Assert
            var result = commentRepository.GetAll();
            Assert.That(result.Count, Is.EqualTo(2));
            // Assert.That(result.Any(c => c.CateId == 3), Is.False);
        }

        [Test]
        public void GetCommentByBook_WhenCalled_ReturnsCommentsForSpecifiedBook()
        {
            // Arrange
            int bookId = 2;
            var newComment = new Comment
            {
                CommentId = 4,
                BookId = bookId, // Use the book ID being tested
                Content = "Content 4",
                CreatedDate = DateTime.Now,
                IsActive = true,
            };
            commentRepository.Create(newComment);

            // Act
            var result = commentRepository.GetCommentByBook(bookId);

            // Assert
            Assert.That(result, Has.One.Matches<Comment>(c => c.CommentId == newComment.CommentId && c.BookId == bookId));
        }

    }
}
