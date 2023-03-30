using FA.BookStore.Core.Repository.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.BookStore.UI.Manager
{
    public class CategoryManager
    {
        private readonly IUnitOfWork repository = new UnitOfWork();

        /// <summary>
        /// Gett All Book
        /// </summary>
        public void DisplayAllCategory()
        {
            using (var uow = new UnitOfWork())
            {
                var books = uow.CategoryRepository.GetAll();

                books.ToList().ForEach(c => Console.WriteLine($"{c.CateId}|" +
                    $"{c.CateName}\t|" +
                    $"{c.Description}\t|" 
                  ));
            }

        }

    }
}
