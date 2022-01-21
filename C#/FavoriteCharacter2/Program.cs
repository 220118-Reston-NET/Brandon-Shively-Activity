using Data;

InitialMenu menu1 = new InitialMenu();
Console.WriteLine("You must add the first character to the list.");

string _voting = "true";
string _continuevoting = "true";
while (_voting == "true")
{
    menu1.CurrentMenu();
    menu1.UserSelection();
    while (_continuevoting == "true")
    {
        Console.WriteLine("Would you like to keep voting?");
        Console.WriteLine("Yes or No");
        _continuevoting = Console.ReadLine();
        if (_continuevoting == "Yes")
        {
            _voting = "true";
            _continuevoting = "false";
        }  
        else if (_voting == "No")
        {
            _voting = "false";
            _continuevoting = "false";
        }
        else
        {
            Console.WriteLine("I didn't understand that");
            _continuevoting = "true";
        }
    }
}
Console.WriteLine("Goodbye");


