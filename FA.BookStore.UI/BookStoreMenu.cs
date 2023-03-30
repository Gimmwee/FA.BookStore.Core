using FA.BookStore.UI.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.BookStore.UI
{
    public class BookStoreMenu
    {
        /// <summary>
        /// Main menu
        /// </summary>
        public void Menu()
        {
            do
            {
                Console.WriteLine("1. Book");
                Console.WriteLine("2. Category");
                Console.WriteLine("3. Publisher");
                Console.WriteLine("0. Exit");
                int choice;
                do
                {
                    Console.Write("--Enter Choice:");
                } while (!int.TryParse(Console.ReadLine(), out choice));
                switch (choice)
                {
                    case 1:
                        BookMenu();
                        break;
                    case 2:
                        CategoryMenu();
                        break;
                    case 3:
                        PublisherMenu();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wrong choice!");
                        break;
                }
            } while (true);
        }
        /// <summary>
        /// Publisher menu
        /// </summary>
        public void PublisherMenu()
        {
            do
            {
                Console.WriteLine("1. FindPublisherById");
                Console.WriteLine("2. AddPublisher");
                Console.WriteLine("3. UpdatePublisher");
                Console.WriteLine("4. DeletePublisher");
                Console.WriteLine("5. GetAllPublisher");
                Console.WriteLine("0. Exit");
                int choice;
                do
                {
                    Console.Write("--Enter Choice:");
                } while (!int.TryParse(Console.ReadLine(), out choice));
                switch (choice)
                {
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 0:
                        Menu();
                        break;
                    default:
                        Console.WriteLine("Wrong choice!");
                        break;
                }
            } while (true);
        }
        /// <summary>
        /// Category menu
        /// </summary>
        public void CategoryMenu()
        {
            var m = new CategoryManager();
            do
            {
                Console.WriteLine("1. FindCategoryById");
                Console.WriteLine("2. AddCategory");
                Console.WriteLine("3. UpdateCategory");
                Console.WriteLine("4. DeleteCategory");
                Console.WriteLine("5. GetAllCategory");
                Console.WriteLine("0. Exit");
                int choice;
                do
                {
                    Console.Write("--Enter Choice:");
                } while (!int.TryParse(Console.ReadLine(), out choice));
                switch (choice)
                {
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:

                        break;

                    case 4:
                        break;
                    case 5:
                        try
                        {
                             m.DisplayAllCategory();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error: " + ex.Message);       
                        }
                        break;
                    case 0:

                        Menu();
                        break;
                    default:
                        Console.WriteLine("Wrong choice!");
                        break;
                }
            } while (true);
        }
        /// <summary>
        /// Book menu
        /// </summary>
        public void BookMenu()
        {
            var manage = new BookManager();
            do
            {
                Console.WriteLine("1. FindBookById");
                Console.WriteLine("2. AddBook");
                Console.WriteLine("3. UpdateBook");
                Console.WriteLine("4. DeleteBook");
                Console.WriteLine("5. GetAllBook");
                Console.WriteLine("6. FindBookByTitle");
                Console.WriteLine("7. FindBookBySummary");
                Console.WriteLine("8. GetLatestBook");
                Console.WriteLine("9. GetBooksByMonth");
                Console.WriteLine("10. CountBooksForCategory");
                Console.WriteLine("11. GetBooksByCategory");
                Console.WriteLine("12. CountBooksForPublisher");
                Console.WriteLine("13. GetBooksByPublisher");
                Console.WriteLine("0. Exit");
                int choice;
                do
                {
                    Console.Write("--Enter Choice:");
                } while (!int.TryParse(Console.ReadLine(), out choice));
                switch (choice)
                {
                    case 0:
                        Menu();
                        break;
                    case 1:
                        try
                        {
                            manage.FindBookById();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error: " + ex.Message);
                        }
                        break;
                    case 2:
                        try
                        {
                            manage.CreateBook();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error: " + ex.Message);
                        }
                        break;
                    case 3:
                        try
                        {
                            manage.UpdateBook();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error: " + ex.Message);
                        }
                        break;
                    case 4:
                        try
                        {
                            manage.DeleteBook();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error: " + ex.Message);
                        }
                        break;
                    case 5:
                        try
                        {
                            manage.DisplayAllBook();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error: " + ex.Message);
                        }
                        break;
                    case 6:
                        try
                        {

                            manage.FindBookByTitle();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error: " + ex.Message);
                        }
                        break;
                    case 7:
                        try
                        {
                            manage.FindBookBySummary();
                        }
                        catch (Exception ex)
                        {

                        }
                        break;
                    case 8:
                        try
                        {
                            manage.GetLatestBook();
                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine("Error: " + ex.Message);
                        }
                        break;
                    case 9:
                        try
                        {
                            manage.GetBooksByMonth();
                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine("Error: " + ex.Message);
                        }
                        break;
                    case 10:
                        try
                        {
                            manage.CountBooksForCategory();
                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine("Error: " + ex.Message);
                        }
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    case 13:
                        break;
                    default:
                        Console.WriteLine("Wrong choice!");
                        break;
                }
            } while (true);
        }
    }
}
