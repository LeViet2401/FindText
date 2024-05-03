using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindText
{
    internal interface IOption
    {
        string Command { get; }
        bool Contant { get; }
        bool Distinguish { get; }
        bool LineNumber { get; }
        void GetOption();
    }
}
