// See https://aka.ms/new-console-template for more information
using BuildFunction;

Menu menu1 = new Menu();
menu1.BuildMenu();

string _keepCounting = "true";

while (_keepCounting == "true")
{
    string _userChoice = Console.ReadLine();
    switch (_userChoice)
    {
        case "1":
            Console.WriteLine("You selected: Dean Winchester");
            _keepCounting = "false";
            break;
        case "2":
            Console.WriteLine("You selected: Sam Winchester");
            _keepCounting = "false";
            break;
        case "3":
            Console.WriteLine("You selected: Castiel");
            _keepCounting = "false";
            break;
        case "4":
            Console.WriteLine("You selected: Bobby Singer");
            _keepCounting = "false";
            break;
        case "5":
            Console.WriteLine("You selected: Unlisted");
            _keepCounting = "false";
            break;
        default:
            Console.WriteLine("You did not select a valid option");
            menu1.BuildMenu();
            break;
    }
}