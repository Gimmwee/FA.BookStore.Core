using FA.BookStore.Core.Data;
using FA.BookStore.Core.Repository.ImplementRepo;
using FA.BookStore.Core.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.BookStore.UnitTests
{
    public class BaseTest
    {
        protected ICategoryRepository categoryRepository;
        protected IBookRepository bookRepository;
        protected IPublisherRepository publisherRepository;
        protected ICommentRepository commentRepository;
        protected BookStoreContext _context;

        public BaseTest()
        {
            DbContextOptions<BookStoreContext> dbContextOptions = new DbContextOptionsBuilder<BookStoreContext>()
                .UseInMemoryDatabase(databaseName: "BookDb2").Options;

            _context = new BookStoreContext(dbContextOptions);
            _context.Seed();

            categoryRepository = new CategoryRepository(_context);
            bookRepository = new BookRepository(_context);
            publisherRepository = new PublisherRepository(_context);
            commentRepository = new CommentRepository(_context);    
        }

    }
}
