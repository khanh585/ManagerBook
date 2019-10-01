using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   

namespace ManagerBookLib
{
    public class BookManager : List<Book>
    {
        public void addNewBook()
        {
            Console.WriteLine("----Add New Book----");

            this.Add(createBook());
            Console.WriteLine("Add completed");
        }

        public void updateABook()
        {
            Console.WriteLine("----Update Book----");
            if (this == null || this.Count == 0)
            {
                Console.WriteLine("List book is empty");
                return;
            }
            Console.Write("Enter id: ");
            String id = Console.ReadLine();
            Book bo = findBookbyID(id);
            if (bo != null)
            {
                int index = this.IndexOf(bo);

                this.Insert(index, updateBook(bo.ID));
                this.Remove(bo);
                Console.WriteLine("Update Completed");
            }
            else
            {
                Console.WriteLine("this book not exist");
                Console.WriteLine("Updae Done");
            }



        }

        public void deleteABook()
        {
            Console.WriteLine("----Delete Book----");
            if (this == null || this.Count == 0)
            {
                Console.WriteLine("List book is empty");
                return;
            }
            Console.Write("Enter id: ");
            String id = Console.ReadLine();
            Book bo = findBookbyID(id);
            if (bo != null)
            {
                this.Remove(bo);
                Console.WriteLine("Delete Completed");
            }
            else
            {
                Console.WriteLine("this book not exist");
                Console.WriteLine("Delete Done");
            }

        }

        public void listAllBook()
        {
            Console.WriteLine("----List Books----");
            if (this == null || this.Count == 0)
            {
                Console.WriteLine("List book is empty");
                return;
            }
            Console.WriteLine("{0,-20} | {1,-20} | {2,-20} | {3,-20}",
                                "ID", "Name", "Publisher", "Price");
            foreach (Book book in this)
            {
                Console.WriteLine(book.toString());
            }
        }

        public Book createBook()
        {
            Book book = new Book();
            string id = "";
            do
            {
                id = Util.inputID();
                if (findBookbyID(id) != null)
                {
                    Console.WriteLine("id is exist, please enter again!!");
                }
                else
                {
                    book.ID = id;
                    break;
                }

            } while (true);
            book.Name = Util.inputName();
            book.Publisher = Util.inputPublisher();
            book.Price = Util.inputPrice();

            return book;
        }

        public Book updateBook(string id)
        {
            Book book = new Book();
            book.ID = id;
            book.Name = Util.inputName();
            book.Publisher = Util.inputPublisher();
            book.Price = Util.inputPrice();

            return book;
        }

        public Book findBookbyID(string ID)
        {
            foreach (Book book in this)
            {
                if (book.ID.Equals(ID))
                {
                    return book;
                }

            }
            return null;

        }

    }
}
