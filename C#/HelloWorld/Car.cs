// //Namespaces organize code very well

namespace CarFunction
{
//     //This is how to create a class using class keyword
// //Public makes the class visible to everything
 public class Car
     {

//         //Field
//         //It is used to store information or define the current state of the object when you first make it
//         //Private means only the class can use that field
//         private string _color = "Blue";

         public int GallonPerMile { get; set; }

//         //Property
//         //They are in PascalCase
//         public string Color
//         {
//             //get keyword in a proprety is a way to get a private field mutable
//             get{ return "The color is: "+_color; }

//             //set keyword is a preperty is how you can make one of your private fields writable
//             set{ _color = value; }
//         }

//         private string _owner; 

//         public string Owner
//         {
//             get{ return "The owner is: "+ _owner; }
//             set{ _owner = value; }
//         }

         public int Fuel { get; set; }

//         public Car()
//         {
//             _color = "Blue";
//             GallonPerMile = 10;
//             _owner = "No Owner";
//             Fuel = 100;
//         }

//         //A method will run mutiple lines of code to do some sort of operation

//         public void Start()
//         {
//             Console.WriteLine("The car is starting now!");
//             Console.WriteLine($"The current fuel is: {Fuel}");
//         }
//         public void Start(int p_fuel)
//         {
//             Fuel = p_fuel;
//             Console.WriteLine("The car is starting now!");
//             Console.WriteLine($"The current fuel is: {Fuel}");
//         }

    // Console.WriteLine("Welcome to programming!");
    // Console.WriteLine("Please tell me your name");
    // string userInput = Console.ReadLine();
    // Console.WriteLine($"Hello {userInput}, what do you want to do today?");

    public int TotalDistance()
    {
        return Fuel/GallonPerMile;
    }
    }
}