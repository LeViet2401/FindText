using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindText
{
    internal class FindTextBuilder : IFindTextBuilder
    {
        private FindCommand command;
        private FindText findText;
        private IFindTextBuilder _builder;
        private IInput input;
        private DefautOption option;
        private IOutput output;

        public FindTextBuilder(FindCommand command)
        {
            this.command = command;
        }
        public IFindTextBuilder Build()
        {
            string[] strings = input.GetInput();
            findText = new FindText(command.Text, strings, option);
            output.MakeOutput(findText.Run());

            
            return _builder;
        }

        public IFindTextBuilder GetInput()
        {
            if(command.Path == null)
            {
                input = new ConsoleInput();
            }
            else
            {
                input = new FileInput(command.Path);
            }
            return this;
        }

        public IFindTextBuilder GetOption()
        {
            option = new DefautOption();
            option.Command = this.command.Option;
            return this;
        }

        public IFindTextBuilder GetOutput()
        {
            if(command.Option.Contains("/c"))
            {
                output = new PrintCount();
            }
            else
            {
                output = new PrinterLine();
            }
            return this;
        }
    }
}
