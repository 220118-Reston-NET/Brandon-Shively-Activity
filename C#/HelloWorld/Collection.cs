using System.Collections;

namespace CollectionFunction
{

    public class Collection
    {
        //Array
        //Used to store a datatype and have a fixed size
        //Syntax: (datatype)[] (name of variable) = new (datatype)[size of the array]
        //zero based index
        private int[] _nums = new int[5];

        //Generic Collection
        //They store a specific datatype and have variable size
        //Syntax: <(datatype)>

            //List Collection
            //Zero based index
            //Used to store a datatype and has variable size
            private List<string> _strings = new List<string>();

            //Hashset Collection
            //There is no particular order to the ellements
            //You cannot have duplicate elements
            private HashSet<int> _numsCollection = new HashSet<int>();

            //dictionary Collection
            //Stores information through key-value pairs
            //There is no particular order
            private Dictionary<string,int> _directory = new Dictionary<string, int>();

        //Non-generic Collection
        //They store any datatype and have variable size
            private ArrayList _nonGeneric = new ArrayList();


        public void CollectionMain()
        {
            Console.WriteLine("===Collection Demo===");

            _nums[0] = 3;
            _nums[1] = 10;
            _nums[2] = 4;

            foreach (int num in _nums)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("===Generic Collection===");
            Console.WriteLine("=List Demo=");
            _strings.Add("First element");
            _strings.Add("Second element");
            _strings.Add("Third element");

            foreach (string item in _strings)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("=Hashset Demo=");
            _numsCollection.Add(2);
            _numsCollection.Add(6);
            _numsCollection.Add(18);

            foreach (int item in _numsCollection)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("=Dictionary Demo=");
            _directory.Add("Stephen", -100000);
            _directory.Add("Vijhan", 1000);
            _directory.Add("Jonathon", -200);

            Console.WriteLine(_directory["Stephen"]);

            Console.WriteLine("===Non Gneeric===");
            _nonGeneric.Add("Stephen");
            _nonGeneric.Add(5);
            _nonGeneric.Add(true);
            _nonGeneric.Add(10.70);

            Console.WriteLine(Convert.ToInt16(_nonGeneric[1])+Convert.ToDouble(_nonGeneric[3]));

        }
    }
}