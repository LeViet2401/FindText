using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindText
{
    internal class ConsoleInput : IInput
    {
        public string[] GetInput()
        {
            string[] input = new string[1];
            input[0] = Console.ReadLine();
            return input;
        }
    }
}
