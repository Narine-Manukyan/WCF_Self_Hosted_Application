using System;
using System.Collections.Generic;
using System.Linq;

namespace BookLibrary
{
    /// <summary>
    /// WCF self-hosted service n which allows to do some work with library.
    /// </summary>
    public class WorkWithBookService : IWorkWithBookService
    {

        /// <summary>
        /// Allows to see all the books in the library.
        /// </summary>
        /// <param name="books">Library</param>
        public void ShowLibrary(List<Book> books)
        {
            foreach (Book item in books)
            {
                Console.WriteLine(item.ToString());
            }
        }

        /// <summary>
        /// Allows to add new book in the library.
        /// </summary>
        /// <param name="books">Library</param>
        public void AddNewBook(List<Book> books, Book book)
        {
            books.Add(book);
        }

        /// <summary>
        /// Allows to update book price.
        /// </summary>
        /// <param name="book">Book in Library</param>
        public void UpdateBookPrice(List<Book> books, Book book, decimal price)
        {
            Book b = books.Where(x => x.ID == book.ID).FirstOrDefault();
            if (b != null)
            {
                b.Price = price;
                Console.WriteLine("1 Row is updated");
            }
            else
                Console.WriteLine("There is nor element like it...");
        }
    }
}
