namespace ConversionFunction
{
    public class Conversion
    {
        public static int _num;
        public static void ConversionMain()
        {
            //Implicit - something is done autoamtically
            //Explicit - you have to write something to do it
            Console.WriteLine("===Conversion Demo===");
            int x = 10;
            double y = 85.29;
            //string str = "Hello World";

            //Implicit Conversion
            //Generally this will only happen if you do not lose information
            double _anotherDouble = x;
            Console.WriteLine(_anotherDouble);

            //Explicit Conversion
            //Needed if you will be losing data
            int _anotherInt = Convert.ToInt16(y);
            Console.WriteLine(_anotherInt);
        }

        public int GiveMeNumber()
        {
            return _num;
        }
    }
}