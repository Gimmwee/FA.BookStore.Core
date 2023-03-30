using FA.BookStore.Core.Models;
using FA.BookStore.Core.Repository.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.BookStore.Core.Repository.IRepository
{
    public interface IPublisherRepository : IGenericRepository<Publisher>
    {
    }
}
