﻿// <auto-generated />
using System;
using FA.BookStore.Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FA.BookStore.Core.Migrations
{
    [DbContext(typeof(BookStoreContext))]
    partial class BookStoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FA.BookStore.Core.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"), 1L, 1);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("CateId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImgUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("PubId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("BookId");

                    b.HasIndex("CateId");

                    b.HasIndex("PubId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            AuthorId = 1,
                            CateId = 1,
                            CreatedDate = new DateTime(2023, 3, 23, 17, 51, 54, 235, DateTimeKind.Local).AddTicks(3185),
                            ImgUrl = "trendinhphowall.jnp",
                            IsActive = true,
                            ModifiedDate = new DateTime(2023, 3, 23, 17, 51, 54, 235, DateTimeKind.Local).AddTicks(3192),
                            Price = 9f,
                            PubId = 1,
                            Quantity = 100,
                            Summary = "The story takes place in a small town in Alabama during the Great Depression",
                            Title = "Tren Dinh Pho Wall"
                        },
                        new
                        {
                            BookId = 2,
                            AuthorId = 2,
                            CateId = 2,
                            CreatedDate = new DateTime(2023, 3, 23, 17, 51, 54, 235, DateTimeKind.Local).AddTicks(3194),
                            ImgUrl = "https://example.com/the-catcher-in-the-rye.jpg",
                            IsActive = false,
                            ModifiedDate = new DateTime(2023, 3, 23, 17, 51, 54, 235, DateTimeKind.Local).AddTicks(3195),
                            Price = 8f,
                            PubId = 2,
                            Quantity = 50,
                            Summary = "The story follows the life of a teenage boy named Holden Caulfield",
                            Title = "The Hopitals in the Russsia"
                        },
                        new
                        {
                            BookId = 3,
                            AuthorId = 3,
                            CateId = 3,
                            CreatedDate = new DateTime(2023, 3, 23, 17, 51, 54, 235, DateTimeKind.Local).AddTicks(3196),
                            ImgUrl = "Alchemist.jnp",
                            IsActive = true,
                            ModifiedDate = new DateTime(2023, 3, 23, 17, 51, 54, 235, DateTimeKind.Local).AddTicks(3196),
                            Price = 3f,
                            PubId = 3,
                            Quantity = 3,
                            Summary = "A novel by Paulo Coelho",
                            Title = "The Alchemist"
                        });
                });

            modelBuilder.Entity("FA.BookStore.Core.Models.Category", b =>
                {
                    b.Property<int>("CateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CateId"), 1L, 1);

                    b.Property<string>("CateName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("CateId");

                    b.ToTable("Categorys");

                    b.HasData(
                        new
                        {
                            CateId = 1,
                            CateName = "Fiction",
                            Description = "A category for fictional works"
                        },
                        new
                        {
                            CateId = 2,
                            CateName = "Fantasy",
                            Description = "A category for works that involve magical or supernatural elements"
                        },
                        new
                        {
                            CateId = 3,
                            CateName = "Non-Fiction",
                            Description = "A category for works that are based on factual information"
                        });
                });

            modelBuilder.Entity("FA.BookStore.Core.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommentId"), 1L, 1);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("CommentId");

                    b.HasIndex("BookId");

                    b.ToTable("Comment");

                    b.HasData(
                        new
                        {
                            CommentId = 1,
                            BookId = 2,
                            Content = "I loved The Great Gatsby! ",
                            CreatedDate = new DateTime(2023, 3, 23, 17, 51, 54, 235, DateTimeKind.Local).AddTicks(3221),
                            IsActive = true
                        },
                        new
                        {
                            CommentId = 2,
                            BookId = 3,
                            Content = "To Kill a Mockingbird was such",
                            CreatedDate = new DateTime(2023, 3, 23, 17, 51, 54, 235, DateTimeKind.Local).AddTicks(3221),
                            IsActive = false
                        },
                        new
                        {
                            CommentId = 3,
                            BookId = 1,
                            Content = "The Lord of the Rings is a true masterpiece.",
                            CreatedDate = new DateTime(2023, 3, 23, 17, 51, 54, 235, DateTimeKind.Local).AddTicks(3222),
                            IsActive = true
                        });
                });

            modelBuilder.Entity("FA.BookStore.Core.Models.Publisher", b =>
                {
                    b.Property<int>("PubId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PubId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("PubId");

                    b.ToTable("Publishers");

                    b.HasData(
                        new
                        {
                            PubId = 1,
                            Description = "the decadence and excess of the Roaring Twenties.",
                            Name = "The Great Beer"
                        },
                        new
                        {
                            PubId = 2,
                            Description = "Injustice in the American South.",
                            Name = "Pingchilling"
                        },
                        new
                        {
                            PubId = 3,
                            Description = "The One Ring and save Middle-earth from the Dark Lord Sauron.",
                            Name = "The line"
                        });
                });

            modelBuilder.Entity("FA.BookStore.Core.Models.Book", b =>
                {
                    b.HasOne("FA.BookStore.Core.Models.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FA.BookStore.Core.Models.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("PubId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("FA.BookStore.Core.Models.Comment", b =>
                {
                    b.HasOne("FA.BookStore.Core.Models.Book", "Book")
                        .WithMany("Comments")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");
                });

            modelBuilder.Entity("FA.BookStore.Core.Models.Book", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("FA.BookStore.Core.Models.Category", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("FA.BookStore.Core.Models.Publisher", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
