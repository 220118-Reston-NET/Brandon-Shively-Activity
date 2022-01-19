// See https://aka.ms/new-console-template for more information
using BuildFunction;

Menu menu1 = new Menu();
menu1.BuildMenu();

string keepCounting = "true";

while (keepCounting == "true")
{
    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            Console.WriteLine("You selected: Dean Winchester");
            keepCounting = "false";
            break;
        case "2":
            Console.WriteLine("You selected: Sam Winchester");
            keepCounting = "false";
            break;
        case "3":
            Console.WriteLine("You selected: Castiel");
            keepCounting = "false";
            break;
        case "4":
            Console.WriteLine("You selected: Bobby Singer");
            keepCounting = "false";
            break;
        case "5":
            Console.WriteLine("You selected: Unlisted");
            keepCounting = "false";
            break;
        default:
            Console.WriteLine("You did not select a valid option");
            menu1.BuildMenu();
            break;
    }
}