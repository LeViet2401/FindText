using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindText
{
    internal class DefautOption : IOption
    {
        public string Command { get; set; }
        public bool Contant { get; set; }
        public bool Distinguish { get; set; }
        public bool LineNumber { get; set; }
        public void GetOption()
        {
            if (!Command.Contains("/v"))
            {
                Contant = true;
            }
            if (!Command.Contains("/i"))
            {
                Distinguish = true;
            }
            if (!Command.Contains("/n"))
            {
                LineNumber = true;
            }
        }
    }
}
