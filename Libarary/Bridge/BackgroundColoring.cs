using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libarary.Bridge
{
    internal class BackgroundColoring : IBookColoring
    {
        public void ApplyColor(string text, ConsoleColor c)
        {
            Console.BackgroundColor = c;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}



