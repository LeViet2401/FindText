using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindText
{
    internal interface IFindTextBuilder
    {
        IFindTextBuilder GetInput();
        IFindTextBuilder GetOption();
        IFindTextBuilder GetOutput();
        IFindTextBuilder Build();

    }
}
