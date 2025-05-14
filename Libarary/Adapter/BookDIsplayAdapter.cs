using Libarary.Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libarary.Adapter
{
    internal class BookDIsplayAdapter : IBookDisplay
    {
        private readonly Book _book;
        private readonly Dictionary<BookCategory, ConsoleColor> _categoryColors = new()
    {
        { BookCategory.Biography, ConsoleColor.Yellow },
        { BookCategory.SelfHelp, ConsoleColor.Blue },
       { BookCategory.Thriller, ConsoleColor.Gray },
       { BookCategory.ChildrensBooks, ConsoleColor.Red },
       { BookCategory.History, ConsoleColor.Green },
       { BookCategory.Adult, ConsoleColor.Cyan },
        { BookCategory.Holocaust, ConsoleColor.Magenta },

        { BookCategory.NA, ConsoleColor.DarkBlue },
        { BookCategory.YoungAdult, ConsoleColor.DarkMagenta }

    };




        public BookDIsplayAdapter(Book book)
        {
            _book = book;
        }

        public void Display(IBookColoring v, string n = null)
        {
            n ??= _book.ToString();
            ConsoleColor originalColor = Console.ForegroundColor;
            if (_categoryColors.ContainsKey(_book.baseBook.Category))
            {
                v.ApplyColor(n, _categoryColors[_book.baseBook.Category]);


            }



        }

    }
}

