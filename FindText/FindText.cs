using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindText
{
    internal class FindText
    {
        private string text;
        private string[] strings;
        private DefautOption option;
        public FindText(string text, string[] strings, DefautOption option)
        {
            this.strings = strings;
            this.option = option;
            this.text = text;
        }

        public List<string> Run()
        {
            List<string> result = new List<string>();
            string check = string.Empty;
            for (int i = 0; i < strings.Length; i++)
            {
                if (option.Distinguish)
                {
                    check = strings[i].ToLower();
                    text = text.ToLower();
                }
                else
                {
                    check = strings[i];
                }
                if (option.LineNumber)
                {
                    check = $"{i} {check}";
                }
                if (option.Contant && check.Contains(text))
                {
                    result.Add(check);
                }
                else if(!check.Contains(text))
                {
                    result.Add(check);
                }
            }
            return result;
        }
    }
}
