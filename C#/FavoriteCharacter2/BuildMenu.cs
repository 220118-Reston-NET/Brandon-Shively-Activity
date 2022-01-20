namespace MenuFunction;

public class BuildMenu
{
    public List<string> _characters = new List<string>();
    public List<int> _vote = new List<int>();
    public int i = 0;

    public void ShowMenu()
    {
        string _keepVoting = "true";
        _characters.Add("Dean Winchester");
        _characters.Add("Sam Winchester");
        _characters.Add("Character not listed");

        while (_keepVoting == "true")
        {
            i = 0;
            Console.WriteLine("Please select your favorite character from Supernatural");
            foreach (string name in _characters)
            {
                Console.WriteLine($"{i+1}. {_characters[i]}");
                i++;
            }
            int _userChoice = Convert.ToInt16(Console.ReadLine());
            if (_userChoice == _characters.Count)
            {
                Console.WriteLine("You have selected: "+_characters[_userChoice-1]);
                Console.WriteLine("Would you like to add your favorite character?");
                Console.WriteLine("Yes or No");
                string _userInput = Console.ReadLine();
                if (_userInput == "Yes")
                {
                    Console.WriteLine("Please type your favorite characters name.");
                    string _userCharacter = Console.ReadLine();
                    _characters.Insert(_characters.Count -1, _userCharacter);
                    _userChoice = -1;
                }
                else if (_userInput == "No")
                {
                    Console.WriteLine("Thank you");
                    _userChoice = -1;
                }
                else
                {
                    Console.WriteLine("I didn't understand that");
                }
                string _addContinue = "true";
                while (_addContinue == "true")
                {
                    Console.WriteLine("Would you like to keeep voting.");
                    Console.WriteLine("Yes or No");
                    string _userContinue = Console.ReadLine();
                    if(_userContinue == "No")
                    {
                        _keepVoting = "false";
                        _addContinue = "false";
                    }
                    else if(_userContinue == "Yes")
                    {
                        _addContinue = "false";
                    }
                    else
                    {
                        Console.WriteLine("I didn't understand that.");
                    }
                }
            }

            else
            {
                Console.WriteLine("You have selected: "+_characters[_userChoice-1]);
                string _addContinue = "true";
                string _userContinue = "a";
                while (_addContinue == "true")
                {
                    Console.WriteLine("Would you like to keeep voting.");
                    Console.WriteLine("Yes or No");
                    _userContinue = Console.ReadLine();
                    if(_userContinue == "No")
                    {
                        _keepVoting = "false";
                        _addContinue = "false";
                    }
                    else if(_userContinue == "Yes")
                    {
                        _addContinue = "false";
                    }
                    else
                    {
                        Console.WriteLine("I didn't understand that.");
                    }
                }
            }
        }
    }
}

