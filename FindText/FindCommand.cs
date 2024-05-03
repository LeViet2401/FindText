using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindText
{
    internal class FindCommand
    {
        private string FullCommand { get; set; }
        public string? Command { get; set; }
        public string? Option { get; set; }
        public string? Text { get; set; }
        public string? Path { get; set; }

        public FindCommand(string fullcommand)
        {
            this.FullCommand = fullcommand;
        }

        public bool GetCommand()
        {
            if (FullCommand.Substring(0, 4).ToLower() != "find")
            {
                return false;
            }
            else
            {
                Command = "find";
                string[] strings = FullCommand.Split(' ');
                for (int i = 0; i < strings.Length; i++)
                {
                    if (strings[i].Contains("/"))
                    {
                        Option += strings[i];
                    }
                }
                string[] texts = FullCommand.Split("\"");
                Text = texts[1];
                if (texts.Length > 2)
                {
                    Path = texts[2].Trim();
                }
                return true;
            }
        }
    }
}
