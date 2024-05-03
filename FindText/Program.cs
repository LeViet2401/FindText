// See https://aka.ms/new-console-template for more information
using FindText;

Console.WriteLine("vui long nhap command");

string fullcommand = Console.ReadLine();
FindCommand findCommand = new FindCommand(fullcommand);
if(!findCommand.GetCommand())
{
    Console.WriteLine("chua nhap lenh find");
    return;
}
IFindTextBuilder appbuilder = new FindTextBuilder(findCommand);
appbuilder.GetInput()
    .GetOption()
    .GetOutput()
    .Build();

