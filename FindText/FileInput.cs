using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindText
{
    internal class FileInput : IInput
    {
        private string path;
        public FileInput(string path)
        {
            this.path = path;   
        }
        public string[] GetInput()
        {
            if(new FileInfo(path).Exists) 
            {
                return File.ReadAllLines(path);
            }
            return new string[0];
        }
    }
}
