namespace BuildFunction
{
    public class Menu
    {
        private string[] _menu = new string[5];

        public void BuildMenu()
        {
            Console.WriteLine("Please select your favorite Supernatural character");
            Console.WriteLine("");

            _menu[0] = "[1]: Dean Winchester";
            _menu[1] = "[2]: Sam Winchester";
            _menu[2] = "[3]: Castiel";
            _menu[3] = "[4]: Bobby Singer";
            _menu[4] = "[5]: Not Listed";

            foreach (string index in _menu)
            {
                Console.WriteLine(index);
                Console.WriteLine("");
            }
        }
    }
}