using FA.BookStore.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.BookStore.Core.DataContext
{
    public static class BookStoreInitializer
    {
        public static void SeedData(this ModelBuilder builder)
        {


            builder.Entity<Category>().HasData(
                new Category
                {
                    CateId = 1,
                    CateName = "Fiction",
                    Description = "A category for fictional works",

                },
                new Category
                {
                    CateId = 2,
                    CateName = "Fantasy",
                    Description = "A category for works that involve magical or supernatural elements",
                },
                new Category
                {
                    CateId = 3,
                    CateName = "Non-Fiction",
                    Description = "A category for works that are based on factual information",
                }
            );

            _ = builder.Entity<Book>().HasData(
                new Book
                {
                    BookId = 1,
                    Title = "Tren Dinh Pho Wall",
                    CateId = 1,
                    AuthorId = 1,
                    PubId = 1,
                    Summary = "The story takes place in a small town in Alabama during the Great Depression",
                    ImgUrl = "trendinhphowall.jnp",
                    Price = 9,
                    Quantity = 100,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true,


                },
                 new Book
                 {
                     BookId = 2,
                     Title = "The Hopitals in the Russsia",
                     CateId = 2,
                     AuthorId = 2,
                     PubId = 2,
                     Summary = "The story follows the life of a teenage boy named Holden Caulfield",
                     ImgUrl = "https://example.com/the-catcher-in-the-rye.jpg",
                     Price = 8,
                     Quantity = 50,
                     CreatedDate = DateTime.Now,
                     ModifiedDate = DateTime.Now,
                     IsActive = false,
                 },
                 new Book
                 {
                     BookId = 3,
                     Title = "The Alchemist",
                     CateId = 3,
                     AuthorId = 3,
                     PubId = 3,
                     Summary = "A novel by Paulo Coelho",
                     ImgUrl = "Alchemist.jnp",
                     Price = 3,
                     Quantity = 3,
                     CreatedDate = DateTime.Now,
                     ModifiedDate = DateTime.Now,
                     IsActive = true,
                 }
            );


            _ = builder.Entity<Publisher>().HasData(
              new Publisher
              {
                  PubId = 1,
                  Name = "The Great Beer",
                  Description = "the decadence and excess of the Roaring Twenties.",

              },
              new Publisher
              {

                  PubId = 2,
                  Name = "Pingchilling",
                  Description = "Injustice in the American South.",
              },
              new Publisher
              {

                  PubId = 3,
                  Name = "The line",
                  Description = "The One Ring and save Middle-earth from the Dark Lord Sauron.",
              }

          );
            _ = builder.Entity<Comment>().HasData(
             new Comment
             {
                 CommentId = 1,
                 BookId = 2,
                 Content = "I loved The Great Gatsby! ",
                 CreatedDate = DateTime.Now,
                 IsActive = true,

             },
             new Comment
             {

                 CommentId = 2,
                 BookId = 3,
                 Content = "To Kill a Mockingbird was such",
                 CreatedDate = DateTime.Now,
                 IsActive = false,
             },
             new Comment
             {

                 CommentId = 3,
                 BookId = 1,
                 Content = "The Lord of the Rings is a true masterpiece.",
                 CreatedDate = DateTime.Now,
                 IsActive = true,
             }

         );
        }
    }
}
