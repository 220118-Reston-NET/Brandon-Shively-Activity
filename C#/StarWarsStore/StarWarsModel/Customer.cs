namespace StarWarsModel{
    public class Customer
    {
        private string _name;
        public string Name{
            get { return _name; }
            set { _name = value; }
        }

        private string _address;
        public string Address{
            get { return _address; }
            set { _address = value; }
        }
        
       //Default constructor to add default values to the properties
        public Customer()
        {
            _name = "brandon";
        }
    }
}