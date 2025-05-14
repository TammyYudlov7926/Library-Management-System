


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libarary.Bridge
{
    internal class TextColoring : IBookColoring
    {
        public void ApplyColor(string text, ConsoleColor v)
        {
            Console.ForegroundColor = v;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
