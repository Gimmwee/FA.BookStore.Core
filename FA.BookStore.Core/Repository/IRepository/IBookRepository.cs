using FA.BookStore.Core.Models;
using FA.BookStore.Core.Repository.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.BookStore.Core.Repository.IRepository
{
    public interface IBookRepository : IGenericRepository<Book>
    {
        Book FindBookByTitle(string title);
        Book FindBookBySummary(string summary);
        IEnumerable<Book> GetLatestBooks(int size);
        IEnumerable<Book> GetBooksByMonth(DateTime monthYear);
        int CountBooksForCategory(string category);
        IEnumerable<Book> GetBooksByCategory(string category);
        int CountBooksForPublisher(string publisher);
        IEnumerable<Book> GetBooksByPublisher(string publisher);


    }
}
