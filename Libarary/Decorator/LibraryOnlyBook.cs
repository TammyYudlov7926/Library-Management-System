using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libarary.Decorator
{
    internal class LibraryOnlyBook : BookDecorator
    {
        public LibraryOnlyBook(IBook book) : base(book) { }

        public override void Display()
        {
            base.Display();
            Console.WriteLine(" Can only be read in the library");
        }
    }
}



