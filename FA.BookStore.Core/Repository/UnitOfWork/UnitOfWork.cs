using FA.BookStore.Core.Data;
using FA.BookStore.Core.Repository.ImplementRepo;
using FA.BookStore.Core.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.BookStore.Core.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly BookStoreContext _context;
        private IBookRepository bookRepository;
        private ICategoryRepository categoryRepository;
        private IPublisherRepository publisherRepository;
        public UnitOfWork(BookStoreContext context = null)
        {
            this._context = context ?? new BookStoreContext();
        }
        public IBookRepository BookRepository => bookRepository ?? new BookRepository(_context);

        public ICategoryRepository CategoryRepository => categoryRepository ?? new CategoryRepository(_context);

        public IPublisherRepository PublisherRepository => publisherRepository ?? new PublisherRepository(_context);

        public void SaveChange()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                    Console.WriteLine("Dispose");

                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            Console.WriteLine("Dispose");
            GC.SuppressFinalize(this);
        }
    }
}
