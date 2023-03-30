using FA.BookStore.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace FA.BookStore.Core.data
{
    public static class BookStoreInitializer
    {
        public static void SeedData(this ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(
                new Category
                {
                    CateId = 1,
                    CateName = "Novel",
                    Description = "Good",
                },
                new Category
                {
                    CateId = 2,
                    CateName = "Action",
                    Description = "Good",
                },
                new Category
                {
                    CateId = 3,
                    CateName = "Romance",
                    Description = "Good",
                }
            );

            builder.Entity<Book>().HasData(
                new Book
                {
                    BookId = 1,
                    Title = "The Great Gatsby",
                    CateId = 2,
                    AuthorId = 3,
                    PubId = 1,
                    Summary = "A classic novel about the decadence of the Roaring Twenties.",
                    ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7a/The_Great_Gatsby_Cover_1925_Retouched.jpg/800px-The_Great_Gatsby_Cover_1925_Retouched.jpg",
                    Price = 12.99f,
                    Quantity = 50,
                    CreateDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    isActive = true,
                },
                new Book
                {
                    BookId = 2,
                    Title = "To Kill a Mockingbird",
                    CateId = 3,
                    AuthorId = 1,
                    PubId = 2,
                    Summary = "A powerful story of racism and injustice in the American South.",
                    ImgUrl = "https://th.bing.com/th/id/OIP.e90rU3ca5fIha1ZXnwiZ3AAAAA?pid=ImgDet&rs=1",
                    Price = 9.99f,
                    Quantity = 30,
                    CreateDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    isActive = true,
                },
                new Book
                {
                    BookId = 3,
                    Title = "1984",
                    CateId = 1,
                    AuthorId = 2,
                    PubId = 3,
                    Summary = "A dystopian novel about a totalitarian society where individuality is suppressed.",
                    ImgUrl = "https://upload.wikimedia.org/wikipedia/vi/c/c3/1984first.jpg",
                    Price = 7.99f,
                    Quantity = 20,
                    CreateDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    isActive = true,
                }

            );

            builder.Entity<Publisher>().HasData(
                new Publisher
                {
                    PubId = 1,
                    Name = "Penguin Books",
                    Description = "Penguin Books is a British publishing house. It was co-founded in 1935 by Sir Allen Lane, his brothers Richard and John, as a line of the publishers The Bodley Head, only becoming a separate company the following year. ",
                },
                new Publisher
                {
                    PubId = 2,
                    Name = "O'Reilly Media",
                    Description = "O'Reilly Media is a technology and business book publisher founded in 1978. The company's distinctive brand features a woodcut of an animal on many of its book covers.",
                },
                new Publisher
                {
                    PubId = 3,
                    Name = "Random House",
                    Description = "Random House is an American book publisher and the largest general-interest paperback publisher in the world. It is part of Penguin Random House, which is owned by German media conglomerate Bertelsmann.",
                }
            );

            builder.Entity<Comment>().HasData(
                new Comment
                {
                    CommentId = 1,
                    BookId = 2,
                    Content = "This book is amazing",
                    CreateDate = DateTime.Now,
                    IsActive = true,
                },
                new Comment
                {
                    CommentId = 2,
                    BookId = 3,
                    Content = "I didn't like this book.",
                    CreateDate = DateTime.Now,
                    IsActive = false,
                },
                new Comment
                {
                    CommentId = 3,
                    BookId = 1,
                    Content = "The plot of this book was confusing.",
                    CreateDate = DateTime.Now,
                    IsActive = true,
                }
            );
        }
    }
}
