using FA.BookStore.Core.Models;
using FA.BookStore.Core.Repository.ImplementRepo;
using FA.BookStore.Core.Repository.IRepository;
using FA.BookStore.Core.Repository.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.BookStore.UI.Manager
{
    public class BookManager
    {
        private readonly IUnitOfWork repository = new UnitOfWork();

        /// <summary>
        /// Gett All Book
        /// </summary>
        public void DisplayAllBook()
        {
            using (var uow = new UnitOfWork())
            {
                var books = uow.BookRepository.GetAll();

                books.ToList().ForEach(b => Console.WriteLine($"{b.BookId}|" +
                    $"{b.Title}\t|" +
                    $"{b.CateId}\t|" +
                    $"{b.AuthorId}\t|" +
                    $"{b.PubId}\t|" +
                    $"{b.Summary}\t|" +
                    $"{b.ImgUrl}\t|" +
                    $"{b.Price}\t|" +
                    $"{b.Quantity}\t|" +
                    $"{b.CreatedDate.Value.ToString("dd MMMM yyyy")}\t|" +
                    $"{b.ModifiedDate.Value.ToString("dd MMMM yyyy")}\t|" +
                    $"{b.IsActive}"));
            }

        }
        /// <summary>
        /// Create Book
        /// </summary>
        public void CreateBook()
        {
            using (var uow = new UnitOfWork())
            {
                int bookId;
                do
                {
                    Console.Write("Enter BookId: ");
                } while (!int.TryParse(Console.ReadLine(), out bookId));



                Console.Write("Enter Title: ");
                string title = Console.ReadLine();

                int cateId;
                do
                {
                    Console.Write("Enter CateId: ");
                } while (!int.TryParse(Console.ReadLine(), out cateId));

                int authorId;
                do
                {
                    Console.Write("Enter AuthorId: ");
                } while (!int.TryParse(Console.ReadLine(), out authorId));
                int pubId;
                do
                {
                    Console.Write("Enter PubId: ");
                } while (!int.TryParse(Console.ReadLine(), out pubId));
                Console.Write("Enter Summary: ");
                string summary = Console.ReadLine();

                Console.Write("Enter UrlImg: ");
                string url = Console.ReadLine();

                float price;
                do
                {
                    Console.Write("Enter Price: ");
                } while (!float.TryParse(Console.ReadLine(), out price));

                int quantity;
                do
                {
                    Console.Write("Enter Quantity: ");
                } while (!int.TryParse(Console.ReadLine(), out quantity));


                DateTime createdDate;
                string format = "dd/MM/yyyy";
                do
                {
                    Console.Write("Enter CreatedDate (in dd/MM/yyyy format): ");
                }
                while (!DateTime.TryParseExact(Console.ReadLine(), format, CultureInfo.InvariantCulture, DateTimeStyles.None, out createdDate));

                DateTime modifiedDate;
                do
                {
                    Console.Write("Enter ModifiedDate (in dd/MM/yyyy format): ");
                }
                while (!DateTime.TryParseExact(Console.ReadLine(), format, CultureInfo.InvariantCulture, DateTimeStyles.None, out modifiedDate));

                bool isActive;
                do
                {
                    Console.Write("Enter IsActive (True/False): ");
                } while (!bool.TryParse(Console.ReadLine(), out isActive));

                // Create new Book object
                var newBook = new Book
                {
                    Title = title,
                    CateId = cateId,
                    AuthorId = authorId,
                    PubId = pubId,
                    Summary = summary,
                    ImgUrl = url,
                    Price = price,
                    Quantity = quantity,
                    CreatedDate = createdDate,
                    ModifiedDate = modifiedDate,
                    IsActive = isActive
                };
                // Add new Book to database
                uow.BookRepository.Create(newBook);

                // Commit changes to database
                uow.SaveChange();
                Console.WriteLine("Create Book successfully.");

            }
        }

        public void FindBookById()
        {
            using (var uow = new UnitOfWork())
            {
                Console.WriteLine("Enter Id u want to find:");
                int id = int.Parse(Console.ReadLine());
                var book = uow.BookRepository.Find(id);

                if (book != null)
                {
                    Console.WriteLine($"{book.BookId}|" +
                        $"{book.Title}|" +
                        $"{book.CateId}|" +
                        $"{book.AuthorId}|" +
                        $"{book.PubId}|" +
                        $"{book.Summary}|" +
                        $"{book.ImgUrl}|" +
                        $"{book.Price}|" +
                        $"{book.Quantity}|" +
                        $"{book.CreatedDate.Value.ToString("dd MMMM yyyy")}|" +
                        $"{book.ModifiedDate.Value.ToString("dd MMMM yyyy")}|" +
                        $"{book.IsActive}");
                }
                else
                {
                    Console.WriteLine($"Book with ID {id} not found.");
                }
            }
        }
        /// <summary>
        /// update book
        /// </summary>
        public void UpdateBook()
        {
            using (var uow = new UnitOfWork())
            {
                int bookId;
                do
                {
                    Console.Write("Enter BookId: ");
                } while (!int.TryParse(Console.ReadLine(), out bookId));

                // Find the Book object with the given BookId
                var bookToUpdate = uow.BookRepository.Find(bookId);
                if (bookToUpdate == null)
                {
                    Console.WriteLine("Book not found.");
                    return;
                }

                Console.Write("Enter new Title (leave blank to keep the current value): ");
                string newTitle = Console.ReadLine();
                if (!string.IsNullOrEmpty(newTitle))
                {
                    bookToUpdate.Title = newTitle;
                }

                int newCateId;
                do
                {
                    Console.Write("Enter new CateId (leave blank to keep the current value): ");
                } while (!int.TryParse(Console.ReadLine(), out newCateId) && !string.IsNullOrEmpty(Console.ReadLine()));
                if (newCateId > 0)
                {
                    bookToUpdate.CateId = newCateId;
                }

                int newAuthorId;
                do
                {
                    Console.Write("Enter new AuthorId (leave blank to keep the current value): ");
                } while (!int.TryParse(Console.ReadLine(), out newAuthorId) && !string.IsNullOrEmpty(Console.ReadLine()));
                if (newAuthorId > 0)
                {
                    bookToUpdate.AuthorId = newAuthorId;
                }


                int newPubId;
                do
                {
                    Console.Write("Enter new PublisherId (leave blank to keep the current value): ");
                } while (!int.TryParse(Console.ReadLine(), out newPubId) && !string.IsNullOrEmpty(Console.ReadLine()));
                if (newPubId > 0)
                {
                    bookToUpdate.PubId = newPubId;
                }

                Console.Write("Enter new Summary (leave blank to keep the current value): ");
                string newSummary = Console.ReadLine();
                if (!string.IsNullOrEmpty(newSummary))
                {
                    bookToUpdate.Summary = newSummary;
                }

                Console.Write("Enter new ImgUrl (leave blank to keep the current value): ");
                string newImgUrl = Console.ReadLine();
                if (!string.IsNullOrEmpty(newImgUrl))
                {
                    bookToUpdate.ImgUrl = newImgUrl;
                }

                float newPrice;
                do
                {
                    Console.Write("Enter new Price (leave blank to keep the current value): ");
                } while (!float.TryParse(Console.ReadLine(), out newPrice) && !string.IsNullOrEmpty(Console.ReadLine()));
                if (newPrice > 0)
                {
                    bookToUpdate.Price = newPrice;
                }


                int newQuantity;
                do
                {
                    Console.Write("Enter new Quantity (leave blank to keep the current value): ");
                } while (!int.TryParse(Console.ReadLine(), out newQuantity) && !string.IsNullOrEmpty(Console.ReadLine()));
                if (newQuantity > 0)
                {
                    bookToUpdate.Quantity = newQuantity;
                }

                DateTime newcreatedDate = DateTime.MinValue;
                string format = "dd/MM/yyyy";
                string userInput;
                do
                {
                    Console.Write("Enter new CreatedDate (in dd/MM/yyyy format)-(leave blank to keep the current value): ");
                    userInput = Console.ReadLine();
                } while (!string.IsNullOrEmpty(userInput) && !DateTime.TryParseExact(userInput, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out newcreatedDate));

                if (!string.IsNullOrEmpty(userInput))
                {
                    bookToUpdate.CreatedDate = newcreatedDate;
                }


                DateTime newModifiedDate = DateTime.MinValue;
                string cusInput;
                do
                {
                    Console.Write("Enter new ModifiedDate (in dd/MM/yyyy format)-(leave blank to keep the current value): ");
                    cusInput = Console.ReadLine();
                } while (!string.IsNullOrEmpty(cusInput) && !DateTime.TryParseExact(cusInput, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out newModifiedDate));

                if (!string.IsNullOrEmpty(cusInput))
                {
                    bookToUpdate.ModifiedDate = newModifiedDate;
                }

                bool newisActive;
                do
                {
                    Console.Write("Enter new IsActive (True/False): ");
                } while (!bool.TryParse(Console.ReadLine(), out newisActive));
                bookToUpdate.IsActive = newisActive;

                uow.SaveChange();
                Console.WriteLine("Book updated successfully.");
            }
        }
        /// <summary>
        /// Delete book
        /// </summary>
        public void DeleteBook()
        {
            using (var uow = new UnitOfWork())
            {
                int bookId;
                do
                {
                    Console.Write("\tEnter BookId: ");
                } while (!int.TryParse(Console.ReadLine(), out bookId));

                var bookToDelete = uow.CategoryRepository.Find(bookId);
                if (bookToDelete == null)
                {
                    Console.WriteLine("\tBook not found.");
                    return;
                }

                uow.CategoryRepository.Delete(bookToDelete);
                uow.SaveChange();
                Console.WriteLine("\tBook deleted successfully.");
            }
        }
        /// <summary>
        /// find book by title
        /// </summary>
        public void FindBookByTitle()
        {

            using (var uow = new UnitOfWork())
            {
                Console.Write("Enter Title u want to find:");
                string title = Console.ReadLine();

                var books = uow.BookRepository.GetAll().FirstOrDefault(b => b.Title.ToLower() == title.ToLower());
                Console.WriteLine(books);
            }
        }
        /// <summary>
        /// find book by summary
        /// </summary>
        public void FindBookBySummary()
        {
            using (var uow = new UnitOfWork())
            {
                Console.Write("Enter summary u want to find:");
                string summary = Console.ReadLine();
                var books = uow.BookRepository.GetAll().FirstOrDefault(b => b.Summary.ToLower() == summary.ToLower());
                Console.WriteLine(books);
            }
        }
        /// <summary>
        /// Get latest book
        /// </summary>
        public void GetLatestBook()
        {
            using (var uow = new UnitOfWork())
            {
                int size;
                do
                {
                    Console.WriteLine("Enter size:");
                } while (!int.TryParse(Console.ReadLine(), out size));

                var books = uow.BookRepository.GetAll()
                    .OrderByDescending(b => b.CreatedDate)
                    .Take(size)
                    .ToList();
                foreach (var b in books)
                {
                    Console.WriteLine(b);
                }
            }
        }
        /// <summary>
        /// Get book by month
        /// </summary>
        public void GetBooksByMonth()
        {
            using (var uow = new UnitOfWork())
            {
                DateTime monthYear;
                do
                {
                    Console.Write("Enter month and year (MM/yyyy):");
                } while (!DateTime.TryParseExact(Console.ReadLine(), "MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out monthYear));

                int size;
                do
                {
                    Console.Write("Enter size:");
                } while (!int.TryParse(Console.ReadLine(), out size));

                var books = uow.BookRepository.GetAll()
                    .Where(b => b.CreatedDate?.Month == monthYear.Month && b.CreatedDate?.Year == monthYear.Year)
                    .OrderByDescending(b => b.CreatedDate)
                    .Take(size)
                    .ToList();
            }
        }

        public void CountBooksForCategory()
        {
            using (var uow = new UnitOfWork())
            {
                Console.Write("Enter Category:");
                string category = Console.ReadLine();

                var books = uow.BookRepository.GetAll()
                    .Count(b => string.Equals(b.Category.CateName, category, StringComparison.OrdinalIgnoreCase));

                Console.WriteLine(books);
            }
        }

    }
}
