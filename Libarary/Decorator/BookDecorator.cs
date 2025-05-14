using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libarary.Decorator
{
    internal class BookDecorator : IBook
    {

        protected IBook _book;

        public BookDecorator(IBook book)
        {
            _book = book;
        }

        public virtual void Display()
        {
            _book.Display();
        }
    }

}


