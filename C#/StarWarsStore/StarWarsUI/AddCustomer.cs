using StarWarsModel;

namespace StarWarsUI{
    public class AddCustomer : AbstractMenu{
        private List<string> _customers = new List<string>();
        private static Customer _newCustomer = new Customer();
        public void Display()
        {
            Console.WriteLine("Please type the customer's name");
        }

        public string UserChoice()
        {
            string _userInput = Console.ReadLine();
            _customers.Add(_userInput);
            Console.WriteLine(_userInput+ " has been added.");
            Console.WriteLine("Press Enter to return to main menu.");
            Console.ReadLine();
            return "MainMenu";
        }
    }
}