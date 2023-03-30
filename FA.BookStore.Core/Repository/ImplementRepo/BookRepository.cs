using FA.BookStore.Core.Data;
using FA.BookStore.Core.Models;
using FA.BookStore.Core.Repository.GenericRepo;
using FA.BookStore.Core.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.BookStore.Core.Repository.ImplementRepo
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        public BookRepository(BookStoreContext context) : base(context)
        {
        }

        public int CountBooksForCategory(string category)
        {
            return context.Books.Count(x => x.Category.CateName.ToLower() == category.ToLower());
        }

        public int CountBooksForPublisher(string publisher)
        {
            return context.Books.Count(x => x.Publisher.Name.ToLower() == publisher.ToLower());
        }

        public Book FindBookBySummary(string summary)
        {
            return context.Books.FirstOrDefault(x => x.Summary.ToLower() == summary.ToLower());
        }

        public Book FindBookByTitle(string title)
        {
            return context.Books.FirstOrDefault(x => x.Title.ToLower() == title.ToLower());
        }

        public IEnumerable<Book> GetBooksByCategory(string category)
        {
            return context.Books.Where(x => x.Category.CateName.ToLower() == category.ToLower());
        }

        public IEnumerable<Book> GetBooksByMonth(DateTime monthYear)
        {
            return context.Books.Where(x => x.CreatedDate != null && x.CreatedDate.Value.Month == monthYear.Month && x.CreatedDate.Value.Year == monthYear.Year);

        }

        public IEnumerable<Book> GetBooksByPublisher(string publisher)
        {
            return context.Books.Where(x => x.Publisher.Name.ToLower() == publisher.ToLower());
        }

        public IEnumerable<Book> GetLatestBooks(int size)
        {
            return context.Books.OrderByDescending(x => x.CreatedDate).Take(size).ToList();
        }
    }
}
