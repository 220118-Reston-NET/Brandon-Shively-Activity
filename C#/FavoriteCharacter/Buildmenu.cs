namespace BuildFunction
{
    public class Menu
    {
        private string[] _menu = new string[5];

        private string _userChoice;

        public void UserChoice()
        {
            _userChoice = Console.ReadLine();
            if (_userChoice == "1" || _userChoice =="2" || _userChoice =="3" || _userChoice =="4" || _userChoice =="5")
            {
                Console.WriteLine("You choose: "+_menu[Convert.ToInt32(_userChoice)-1]); //exception error can be thrown if a non int  is inputed
            }

            else
            {
                Console.WriteLine("You did not select a valid option");
            }
        }

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