using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libarary.Flyweight
{
    internal class BookCopy
    {

        public int copies { get; set; }
        public string Name { get; }
        public string Author { get; }
        public BookCategory Category { get; }

        public BookCopy(string name, string author, BookCategory category)
        {
            Name = name;
            Author = author;
            Category = category;


        }
        public void DisplayCopies()
        {
            Console.WriteLine($"Copies: {copies}");
        }
    }
}





