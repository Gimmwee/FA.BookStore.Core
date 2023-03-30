using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FA.BookStore.Core.Migrations
{
    public partial class BookStoreDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorys",
                columns: table => new
                {
                    CateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CateName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorys", x => x.CateId);
                });

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    PubId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.PubId);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CateId = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    PubId = table.Column<int>(type: "int", nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Books_Categorys_CateId",
                        column: x => x.CateId,
                        principalTable: "Categorys",
                        principalColumn: "CateId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Publishers_PubId",
                        column: x => x.PubId,
                        principalTable: "Publishers",
                        principalColumn: "PubId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    CommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comment_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categorys",
                columns: new[] { "CateId", "CateName", "Description" },
                values: new object[,]
                {
                    { 1, "Fiction", "A category for fictional works" },
                    { 2, "Fantasy", "A category for works that involve magical or supernatural elements" },
                    { 3, "Non-Fiction", "A category for works that are based on factual information" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "PubId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "the decadence and excess of the Roaring Twenties.", "The Great Beer" },
                    { 2, "Injustice in the American South.", "Pingchilling" },
                    { 3, "The One Ring and save Middle-earth from the Dark Lord Sauron.", "The line" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AuthorId", "CateId", "CreatedDate", "ImgUrl", "IsActive", "ModifiedDate", "Price", "PubId", "Quantity", "Summary", "Title" },
                values: new object[] { 1, 1, 1, new DateTime(2023, 3, 23, 17, 51, 54, 235, DateTimeKind.Local).AddTicks(3185), "trendinhphowall.jnp", true, new DateTime(2023, 3, 23, 17, 51, 54, 235, DateTimeKind.Local).AddTicks(3192), 9f, 1, 100, "The story takes place in a small town in Alabama during the Great Depression", "Tren Dinh Pho Wall" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AuthorId", "CateId", "CreatedDate", "ImgUrl", "IsActive", "ModifiedDate", "Price", "PubId", "Quantity", "Summary", "Title" },
                values: new object[] { 2, 2, 2, new DateTime(2023, 3, 23, 17, 51, 54, 235, DateTimeKind.Local).AddTicks(3194), "https://example.com/the-catcher-in-the-rye.jpg", false, new DateTime(2023, 3, 23, 17, 51, 54, 235, DateTimeKind.Local).AddTicks(3195), 8f, 2, 50, "The story follows the life of a teenage boy named Holden Caulfield", "The Hopitals in the Russsia" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AuthorId", "CateId", "CreatedDate", "ImgUrl", "IsActive", "ModifiedDate", "Price", "PubId", "Quantity", "Summary", "Title" },
                values: new object[] { 3, 3, 3, new DateTime(2023, 3, 23, 17, 51, 54, 235, DateTimeKind.Local).AddTicks(3196), "Alchemist.jnp", true, new DateTime(2023, 3, 23, 17, 51, 54, 235, DateTimeKind.Local).AddTicks(3196), 3f, 3, 3, "A novel by Paulo Coelho", "The Alchemist" });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "CommentId", "BookId", "Content", "CreatedDate", "IsActive" },
                values: new object[] { 1, 2, "I loved The Great Gatsby! ", new DateTime(2023, 3, 23, 17, 51, 54, 235, DateTimeKind.Local).AddTicks(3221), true });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "CommentId", "BookId", "Content", "CreatedDate", "IsActive" },
                values: new object[] { 2, 3, "To Kill a Mockingbird was such", new DateTime(2023, 3, 23, 17, 51, 54, 235, DateTimeKind.Local).AddTicks(3221), false });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "CommentId", "BookId", "Content", "CreatedDate", "IsActive" },
                values: new object[] { 3, 1, "The Lord of the Rings is a true masterpiece.", new DateTime(2023, 3, 23, 17, 51, 54, 235, DateTimeKind.Local).AddTicks(3222), true });

            migrationBuilder.CreateIndex(
                name: "IX_Books_CateId",
                table: "Books",
                column: "CateId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_PubId",
                table: "Books",
                column: "PubId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_BookId",
                table: "Comment",
                column: "BookId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Categorys");

            migrationBuilder.DropTable(
                name: "Publishers");
        }
    }
}
