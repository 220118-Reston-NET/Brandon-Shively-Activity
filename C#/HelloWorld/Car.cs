//Namespaces organize code very well
namespace CarFunction
{
    //This is how to create a class using class keyword
//Public makes the class visible to everything
    public class Car
    {

        //Field
        //It is used to store information or define the current state of the object when you first make it
        //Private means only the class can use that field
        private string _color = "Blue";
        private string _owner;
        private int _fuel;
        private int _gallonPerMile;

        //Property
        //They are in PascalCase
        public string Color
        {
            get{ return "The color is: "+_color; }
        }

    }
}