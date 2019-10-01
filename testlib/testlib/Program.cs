using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagerBookLib;

namespace testlib
{
    class Program
    {
        static void Main(string[] args)
        {
            BookManager mn = new BookManager();
            int choice = 0;
            bool flag = true;
            while (flag)
            {

                Console.WriteLine("=====Book Manager=====");
                Console.WriteLine("1.Add new a book");
                Console.WriteLine("2.Update a book");
                Console.WriteLine("3.Delete a book");
                Console.WriteLine("4.List all book");
                Console.WriteLine("5.Quit");
                Console.Write("Your choice: ");
                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:
                        mn.addNewBook();
                        break;
                    case 2:
                        mn.updateABook();
                        break;
                    case 3:
                        mn.deleteABook();
                        break;
                    case 4:
                        mn.listAllBook();
                        break;
                    case 5:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("choice 1-5, try again");
                        break;
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Enter to exit");
            Console.ReadKey();
        }
    }
}
