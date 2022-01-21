namespace Data;

public class InitialMenu
{
    //starting lists
    private static List<string> _characters = new List<string>(){"See Current Votes", "Search for a character", "Add a character", "Remove a character","Character not listed"};
    private static List<int> _vote = new List<int>();
    private static int i = 0;
    static int _userselection;

    public void CurrentMenu()
    {
        i = 0;
        foreach (string name in _characters)
        {
            Console.WriteLine($"{i+1}. {name}");
            i++;
        };
    }

    public void CurrentVote()
    {
        foreach (int vote in _vote)
        {
            Console.WriteLine($"The current vote for {_characters[i]} is {vote}.");
            i++;
        }
    }

    public void UserSelection()
    {
        _userselection = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("You have selected: "+_characters[_userselection -1]);
        if (_userselection == _characters.Count -4)
        {
            CurrentVote();
        }
        else if (_userselection == _characters.Count -3)
        {
            SearchForCharacter();
        }
        else if (_userselection == _characters.Count -2)
        {
            AddCharacter();
        }
        else if (_userselection == _characters.Count -1)
        {
            RemoveCharacter();
        }
        else if (_userselection == _characters.Count)
        {
            AddCharacter();
        }
        else
        {
            Console.WriteLine("Please select a valid option");
        }
    }

    public void AddCharacter()
    {
        string? _userAdd;
        string? _userCharacter;
        string _keeplooping = "true";
        while (_keeplooping == "true")
        {
            if (_userselection == _characters.Count)
            {
                Console.WriteLine("Your character is not listed would you like to add them?");
                Console.WriteLine("Yes or No");
                _userAdd = Console.ReadLine();
                if (_userAdd == "Yes")
                {
                    Console.WriteLine("Please type your character's name.");
                    _userCharacter = Console.ReadLine();
                    _characters.Insert(_characters.Count -5, _userCharacter);
                    _vote.Add(1); //add the vote of added character
                    _keeplooping = "false";
                }

                else if (_userAdd == "No")
                {
                    Console.WriteLine("OK");
                    //Include a way to increment the vote count of not listed element

                    _keeplooping = "false";
                }

                else
                {
                    Console.WriteLine("I don't understand.");
                }
            }
        }
    }

    public void RemoveCharacter()
    {
        Console.WriteLine("Please type in the character you would like deleted");
        CurrentMenu();
        _userselection = Convert.ToInt16(Console.ReadLine());
        _characters.Remove(_characters[_userselection -1]);
        _vote.RemoveAt(_userselection-1);
        Console.WriteLine("The character has been removed from the list.");
    }

    public void SearchForCharacter()
    {
        string _userName;
        Console.WriteLine("Type the name of the character you would like to search for.");
        _userName = Console.ReadLine();
        if (_characters.IndexOf(_userName) == _userselection -1)
        {
            Console.WriteLine("You're character is in the list.");
        }

        else
        {
            Console.WriteLine("You're character is not in the list.");
            AddCharacter();
        }
    }
}