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
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(BookStoreContext context) : base(context)
        {

        }

    }
}
