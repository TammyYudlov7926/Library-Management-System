using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libarary.Decorator
{
    internal class RecommendedBook : BookDecorator
    {
        public RecommendedBook(IBook book) : base(book) { }

        public override void Display()
        {
            base.Display();
            Console.WriteLine(" Recommended book!");
        }
    }
}
