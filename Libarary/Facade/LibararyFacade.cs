using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libarary.Facade
{
    internal class LibararyFacade
    {
        Library _library { get; set; }
        public LibararyFacade() { _library = new Library(); }
        public Library Library { get { return _library; } }
        public bool BorrowBook(int bookId)
        {
            Book book = _library.FindBookById(bookId);
            if (book == null)
            {
                Console.WriteLine(" The book is not found.");
                return false;
            }

            if (book.Borrow())
            {
                Console.WriteLine($"this book'{book.baseBook.Name}' Successfully borrowed!");
                return true;
            }
            else
            {
                Console.WriteLine("The book has already been borrowed.");
                return false;
            }
        }

        // 2️⃣ החזרת ספר
        public bool ReturnBook(int bookId)
        {
            Book book = _library.FindBookById(bookId);
            if (book == null)
            {
                Console.WriteLine("The book is not found.");
                return false;
            }

            if (book.Return())
            {
                Console.WriteLine($"This book '{book.baseBook.Name}' Successfully returned!");
                return true;
            }
            else
            {
                Console.WriteLine("Successfully returned! The book was not borrowed.");
                return false;
            }
        }
        public bool IsBookAvailable(int bookId)
        {
            Book book = _library.FindBookById(bookId);
            if (book == null)
            {
                Console.WriteLine("The book is not found.");
                return false;
            }
            return !book.IsItBorrowed;
        }
        public void PrintBookById(int bookId)
        {
            Book book = _library.FindBookById(bookId);
            if (book == null)
            {
                Console.WriteLine("Book not found.");
                return;
            }
            book.Display();
        }
        public void PrintBooksByCategory(BookCategory category)
        {
            var books = _library.GetBooksByCategory(category);
            if (!books.Any())
            {
                Console.WriteLine($"There are no books in the category{category}.");
                return;
            }

            Console.WriteLine($"Books in category {category}:");
            foreach (var book in books)
            {
                book.Display();
            }
        }

    }
}








