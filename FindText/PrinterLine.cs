using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindText
{
    internal class PrinterLine : IOutput
    {
        public PrinterLine() { }
        public void MakeOutput(List<string> strings)
        {
            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }
        }
    }
}
