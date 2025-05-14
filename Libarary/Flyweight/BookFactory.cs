using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libarary.Flyweight
{
    internal class BookFactory
    {


        private static Dictionary<string, BookCopy> _books = new Dictionary<string, BookCopy>();

        public BookFactory()
        {

        }
        public BookCopy GetBook(string name, string author, BookCategory category)
        {
            string key = $"{name}{author}{category}";

            if (!_books.ContainsKey(key))
            {
                _books[key] = new BookCopy(name, author, category);
            }


            return _books[key];
        }
    }
}
