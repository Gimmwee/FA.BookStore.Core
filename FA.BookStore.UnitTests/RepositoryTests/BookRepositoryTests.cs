using FA.BookStore.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.BookStore.UnitTests.RepositoryTests
{

    [TestFixture]
    public class BookRepositoryTests : BaseTest
    {
        public BookRepositoryTests() : base()
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
            var result = bookRepository.GetAll();


            // Assert
            Assert.That(result.Count, Is.EqualTo(3));
        }

        [Test]
        public void Find_WhenCalled_ReturnObject()
        {
            var result = bookRepository.Find(2);

            Assert.IsNotNull(result);
        }


        [Test]
        public void AddBook_WhenCalled_ReturnObject()
        {
            // Arrange
            var newBook = new Book
            {
                BookId = 4,
                Title = "Book 4",
                CateId = 4,
                AuthorId = 4,
                PubId = 4,
                Summary = "Summary 4",
                ImgUrl = "",
                Price = 4,
                Quantity = 4,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                IsActive = false,


            };

            // Act
            bookRepository.Create(newBook);

            // Assert
            var result = bookRepository.GetAll();
            Assert.That(result.Count, Is.EqualTo(4));
            Assert.That(result.Last().Title, Is.EqualTo("Book 4"));
        }
        [Test]
        public void UpdateBook_WhenCalled_UpdateBookInDatabase()
        {
            // Arrange
            var bookToUpdate = bookRepository.Find(1);
            bookToUpdate.Title = "Updated Book";

            // Act
            bookRepository.Update(bookToUpdate);

            // Assert
            var result = bookRepository.Find(1);
            Assert.That(result.Title, Is.EqualTo("Updated Book"));
        }
        [Test]
        public void DeleteBook_WhenCalled_RemoveBookFromDatabase()
        {
            // Arrange
            var bookToDelete = bookRepository.Find(3);

            // Act
            bookRepository.Delete(bookToDelete);

            // Assert
            var result = bookRepository.GetAll();
            Assert.That(result.Count, Is.EqualTo(2));
            // Assert.That(result.Any(c => c.CateId == 3), Is.False);
        }



        [Test]
        public void GetLatestBooks_WhenCalled_ReturnValue()
        {
            int size = 3;
            var result = bookRepository.GetLatestBooks(size);
            Assert.AreEqual(size, result.Count());
        }
        [Test]
        public void FindBookByTitle_WhenTitleExists_ReturnBook()
        {
            // Arrange
            string title = "Book 2";
            //bookRepository.Create(new Book { Title = title });

            // Act
            var result = bookRepository.FindBookByTitle(title);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(title, result.Title);
        }
        [Test]
        public void FindBookBySummary_WhenSummaryExists_ReturnBook()
        {
            // Arrange
            string summary = "Summary 2";
            //bookRepository.Create(new Book { Title = title });

            // Act
            var result = bookRepository.FindBookBySummary(summary);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(summary, result.Summary);
        }

        [Test]
        public void GetBooksByMonth_WhenMonthExists_ReturnBooks()
        {
            // Arrange
            var monthYear = new DateTime(2023, 3, 1);

            // Act
            var result = bookRepository.GetBooksByMonth(monthYear);

            // Assert
            Assert.That(result.Count, Is.EqualTo(3));
        }
        [Test]
        public void CountBooksForCategory_WhenCategoryExists_ReturnCount()
        {
            // Arrange
            var category = "Category 2";

            // Act
            var result = bookRepository.CountBooksForCategory(category);

            // Assert
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void GetBooksByCategory_WhenCategoryExists_ReturnBooks()
        {
            // Arrange
            var category = "Category 1";

            // Act
            var result = bookRepository.GetBooksByCategory(category);

            // Assert
            Assert.That(result.Count, Is.EqualTo(1));
        }

        [Test]
        public void CountBooksForPublisher_WhenPublisherExists_ReturnCount()
        {
            // Arrange
            var publisher = "Publisher 2";

            // Act
            var result = bookRepository.CountBooksForPublisher(publisher);

            // Assert
            Assert.That(result, Is.EqualTo(1));
        }



        [Test]
        public void GetBooksByPublisher_WhenPublisherExists_ReturnBooks()
        {
            // Arrange
            var publisher = "Publisher 2";

            // Act
            var result = bookRepository.GetBooksByPublisher(publisher);

            // Assert
            Assert.That(result.Count, Is.EqualTo(1));
        }
    }
}
