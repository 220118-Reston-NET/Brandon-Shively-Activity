using TotalVotesFunction;

namespace BuildFunction
{
    public class Menu
    {
        private static string[] _menu = new string[9];
        public static int[] _votes = new int[5]{0, 0, 0, 0, 0};
        private string _continue = "true";

        public static string _userChoice;

        public void UserChoice()
        {
            while (_continue == "true")
            {
                string _userChoice =  Console.ReadLine();
                if (_userChoice == "1" || _userChoice =="2" || _userChoice =="3" || _userChoice =="4" || _userChoice =="5")
                {
                    Console.WriteLine("You choose: "+_menu[Convert.ToInt32(_userChoice)-1]); //exception error can be thrown if a non int  is inputed
                    _votes[Convert.ToInt32(_userChoice)-1]++;
                    Console.WriteLine($"So far {_votes[Convert.ToInt32(_userChoice)-1]} have choosen {_menu[Convert.ToInt32(_userChoice) - 1]}");
                    Console.WriteLine("");
                    BuildMenu();
                }

                else if (_userChoice == "6")
                {
                    Data.TotalVotesMain();
                    BuildMenu();
                }

                else if (_userChoice == "7")
                {
                    Data.SearchVote();
                    BuildMenu();
                }

                else if (_userChoice == "8")
                {
                    Data.RemoveVote();
                    Array.Copy(Data._rvote, _votes, 5);
                    BuildMenu();
                }

                else if (_userChoice == "9")
                {
                    Console.WriteLine("Total Votes are:");
                    Data.TotalVotesMain();
                    Console.WriteLine("Goodbye");
                    _continue = "false";
                }
                else
                {
                    Console.WriteLine("You did not select a valid option");
                    Console.WriteLine("");
                    BuildMenu();
                }
            }
        }

        public void BuildMenu()
        {
            Console.WriteLine("Please select your favorite Supernatural character");
            Console.WriteLine("");

            _menu[0] = "Dean Winchester";
            _menu[1] = "Sam Winchester";
            _menu[2] = "Castiel";
            _menu[3] = "Bobby Singer";
            _menu[4] = "Not Listed";
            _menu[5] = "See Current Votes";
            _menu[6] = "See Votes for a character";
            _menu[7] = "Switch to removing votes";
            _menu[8] = "Exit Voting";

            for (int i = 1; i < 10; i++)  
            {
                Console.WriteLine($"[{i}]: "+_menu[i-1]);
            }

            Console.WriteLine("");
        }
    }
}