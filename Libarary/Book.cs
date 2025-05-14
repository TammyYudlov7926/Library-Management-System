using Libarary.Adapter;
using Libarary.Bridge;
using Libarary.Composite;
using Libarary.Decorator;
using Libarary.Flyweight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libarary
{
    internal class Book : IBook

    {
        public BookCopy baseBook { get; set; }
        public static int IdCode = 0;
        public int Id { get; set; }

        public bool IsItBorrowed { get; set; }
        public DateTime BorrowingDate { get; set; }
        BookFactory _bookFactory;



        public Book(string name, string author, BookCategory category)
        {
            Id = ++IdCode;
            IsItBorrowed = false;
            _bookFactory = new BookFactory();
            baseBook = _bookFactory.GetBook(name, author, category);

        }
        public Book()
        {
            Id = ++IdCode;
        }
        public override string ToString()
        {
            return $"Name is:{Id}\nAuthor is:{baseBook.Author}\nId is:{Id}\nIsItBorrowed is:{IsItBorrowed}\nBorrowingDate is:{BorrowingDate}\n";
        }
        public void Display()
        {
            IBookColoring bookColoring2=new TextColoring();
            BookDIsplayAdapter bookDIsplayAdapter = new BookDIsplayAdapter(this);
            bookDIsplayAdapter.Display(bookColoring2, baseBook.Name)
            ;
        }
        public bool Borrow()
        {
            if (IsItBorrowed)
                return false;
            IsItBorrowed = true;
            BorrowingDate = DateTime.Now;
            return true;
        }


        public bool Return()
        {
            if (!IsItBorrowed)
                return false;
            IsItBorrowed = false;
            return true;
        }
        public void Display(string copyId, bool isAvailable)
        {
            Console.WriteLine($"copy {copyId}] {baseBook.Name} - {baseBook.Author} available {isAvailable})");
        }

    }
}
