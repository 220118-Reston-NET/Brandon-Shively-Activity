using BuildFunction;

namespace TotalVotesFunction;

    public class Data
    {
        public static string[] _rmenu = new string[6];
        public static int[] _rvote = new int[5]{Menu._votes[0], Menu._votes[1], Menu._votes[2], Menu._votes[3], Menu._votes[4]};

            public static void TotalVotesMain()
            {
                Console.WriteLine($"{Menu._votes[0]} have selected Dean Winchester");
                Console.WriteLine($"{Menu._votes[1]} have selected Sam Winchester");
                Console.WriteLine($"{Menu._votes[2]} have selected Casiel");
                Console.WriteLine($"{Menu._votes[3]} have selected Bobby Singer");
                Console.WriteLine($"{Menu._votes[4]} have selected Unlisted");
            }

            public static void RemoveVote()
            {
                string _rcontinue = "true";
                Array.Copy(Menu._votes, _rvote, 5);
                while (_rcontinue == "true")
                {
                    Console.WriteLine("");
                    RemoveMenu();
                    string _userRemove = Console.ReadLine();
                    Console.WriteLine("");
                    switch (_userRemove)
                    {
                        case "1":
                            Console.WriteLine("Removing a vote from "+_rmenu[0]);
                            _rvote[0]--;
                            Console.WriteLine($"The vote for {_rmenu[0]} is now {_rvote[0]}");
                            break;
                        case "2":
                            Console.WriteLine("Removing a vote from"+_rmenu[1]);
                            _rvote[1]--;
                            Console.WriteLine($"The vote for {_rmenu[1]} is now {_rvote[1]}");
                            break;
                        case "3":
                            Console.WriteLine("Removing a vote from"+_rmenu[2]);
                            _rvote[2]--;
                            Console.WriteLine($"The vote for {_rmenu[2]} is now {_rvote[2]}");
                            break;
                        case "4":
                            Console.WriteLine("Removing a vote from"+_rmenu[3]);
                            _rvote[3]--;
                            Console.WriteLine($"The vote for {_rmenu[3]} is now {_rvote[3]}");
                            break;
                        case "5":
                            Console.WriteLine("Removing a vote from"+_rmenu[4]);
                            _rvote[4]--;
                            Console.WriteLine($"The vote for {_rmenu[4]} is now {_rvote[4]}");
                            break;
                        case "6":
                            Console.WriteLine("Switching back to voting mode.");
                            _rcontinue = "false";
                            break;
                        default:
                            Console.WriteLine("You did not pick a valid option");
                            break;
                    }
                }
            }

            public static void RemoveMenu()
            {
                _rmenu[0] = "Dean Winchester";
                _rmenu[1] = "Sam Winchester";
                _rmenu[2] = "Castiel";
                _rmenu[3] = "Bobby Singer";
                _rmenu[4] = "Not Listed";
                _rmenu[5] = "Return to voting";
                Console.WriteLine("Please select who you would like to remove a vote from:");
                Console.WriteLine("");
                for (int i = 1; i < 7; i++)  
                    {
                        Console.WriteLine($"[{i}]: {_rmenu[i-1]}");
                    }
            }
    }