using Libarary.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libarary.Proxy
{
    internal class RealBookService : IBookService
    {

        public Library _library;

        public RealBookService(Library library)
        {
            _library = library;
        }

        public void DisplayBookInfo(int bookId)
        {
            var book = _library.FindBookById(bookId);
            if (book != null)
            {
                Console.WriteLine($" name: {book.baseBook.Name}, author: {book.baseBook.Author}, category: {book.baseBook.Category}");
            }
            else
            {
                Console.WriteLine("Book not found");
            }
        }

        public bool BorrowBook(int bookId, User user)
        {
            Book book = _library.FindBookById(bookId);
            return book.Borrow();
        }
    }

}