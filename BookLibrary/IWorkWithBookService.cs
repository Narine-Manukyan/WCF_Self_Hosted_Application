using System.Collections.Generic;
using System.ServiceModel;

namespace BookLibrary
{
    /// <summary>
    /// WCF self-hosted service n which allows to do some work with library.
    /// </summary>
    [ServiceContract]
    public interface IWorkWithBookService
    {
        /// <summary>
        /// Allows to see all the books in the library.
        /// </summary>
        /// <param name="books">Library</param>
        [OperationContract]
        void ShowLibrary(List<Book> books);

        /// <summary>
        /// Allows to add new book in the library.
        /// </summary>
        /// <param name="books">Library</param>
        [OperationContract]
        void AddNewBook(List<Book> books, Book book);

        /// <summary>
        /// Allows to update book price.
        /// </summary>
        /// <param name="book">Book in Library</param>
        [OperationContract]
        void UpdateBookPrice(List<Book> books, Book book, decimal price);
    }
}