using FA.BookStore.Core.Data;
using FA.BookStore.Core.Models;
using Microsoft.Isam.Esent.Interop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.BookStore.UnitTests
{
    public static class SeedData
    {

        public static void Seed(this BookStoreContext _context)
        {

            _context.AddRange(GetBooks());
            _context.AddRange(GetCategories());
            _context.AddRange(GetComments());
            _context.AddRange(GetPublishers());

            _context.SaveChanges();
        }

        private static ICollection<Category> GetCategories()
        {
            return new List<Category>()
            {
                 new Category
                {
                    CategoryId = 1,
                    Name = "Chân dung giám đốc trốn nợ được ông Chung cho làm dự án cây xanh",
                    UrlSlug = "chan-dung-giam-dc-trn-n-duc-ong-chung-cho-lam-d-an-cay-xanh",
                    Desciption = "This is an example page for demonstration purposes.",
                },
                new Category
                {
                    CategoryId = 2,
                    Name = "About Us",
                    UrlSlug = "about-us",
                    Desciption = "Learn more about our company and what we do.",
                },
                new Category
                {
                    CategoryId = 3,
                    Name = "Contact to customer",
                    UrlSlug = "contact-to-customer",
                    Desciption = "Get in touch with us for any questions or inquiries.",
                }
            };
        }

        private static ICollection<Publisher> GetPublishers()
        {
            return new List<Publisher>()
            {
                new Publisher
                {
                    PubId = 1,
                    Name = "Publisher 1",
                    Description = "Publisher 1"
                },
                new Publisher
                {
                    PubId = 2,
                    Name = "Publisher 2",
                    Description = "Publisher 2"
                },
                new Publisher
                {
                    PubId = 3,
                    Name = "Publisher 3",
                    Description = "Publisher 3"
                }
            };
        }

        private static ICollection<Book> GetBooks()
        {
            return new List<Book>()
            {
                new Book
                {
                    BookId = 1,
                    Title = "Book 1",
                    CateId = 1,
                    AuthorId = 1,
                    PubId = 1,
                    Summary = "Summary 1",
                    ImgUrl = "",
                    Price = 1,
                    Quantity = 1,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true,
                },
                new Book
                {
                  BookId = 2,
                    Title = "Book 2",
                    CateId = 2,
                    AuthorId = 2,
                    PubId = 2,
                    Summary = "Summary 2",
                    ImgUrl = "",
                    Price = 2,
                    Quantity = 2,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true,
                },
                new Book
                {
                    BookId = 3,
                    Title = "Book 3",
                    CateId = 3,
                    AuthorId = 3,
                    PubId = 3,
                    Summary = "Summary 3",
                    ImgUrl = "",
                    Price = 3,
                    Quantity = 3,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true,
                }
            };

        }


        private static ICollection<Comment> GetComments()
        {
            return new List<Comment>()
            {
                new Comment
                {
                    CommentId = 1,
                 BookId = 1,
                 Content = "Content 1",
                 CreatedDate = DateTime.Now,
                 IsActive = true,
                },
                new Comment
                {
                   CommentId = 2,
                 BookId = 2,
                 Content = "Content 2",
                 CreatedDate = DateTime.Now,
                 IsActive = false,
                },
                new Comment
                {
                   CommentId = 3,
                 BookId = 3,
                 Content = "Content 3",
                 CreatedDate = DateTime.Now,
                 IsActive = true,
                }
            };

        }
    }
}
