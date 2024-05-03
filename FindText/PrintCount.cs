using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindText
{
    internal class PrintCount : IOutput
    {
        public PrintCount() { }
        public void MakeOutput(List<string> strings)
        {
            Console.WriteLine(strings.Count);
        }
    }
}
