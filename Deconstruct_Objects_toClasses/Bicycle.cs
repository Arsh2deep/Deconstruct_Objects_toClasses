namespace Deconstruct_Objects_toClasses
{
    public class Bicycle
    {
        //Fields
        enum TypesofChain { Chain1, Chain2, Chain3 }
        string _breaks;
        TypesofChain _Chain;
        string TypesofWheels;
        int _numberofGears;
        string _frame;
        string _pedals;
        string _handel;
        int _numberofSeats;
        string _uniqueSerial;

        //Constructor

        public Bicycle()
        {
            Random random = new Random();
            int unique = random.Next(100000 - 1000000);
            _uniqueSerial = unique.ToString();
        }

        public Bicycle(string breaks, TypesofChain chain, string typesofWheels, int numberofGears, string frame, string pedals, string handel, int numberofSeats, string uniqueSerial)
        {

            _breaks = breaks;
            _Chain = chain;
            TypesofWheels = typesofWheels;
            _numberofGears = numberofGears;
            _frame = frame;
            _pedals = pedals;
            _handel = handel;
            _numberofSeats = numberofSeats;
            _uniqueSerial = uniqueSerial;
            
        }
        //properties For Bicycle
        public string Breaks { get => _breaks; set => _breaks = value; }
        private TypesofChain Chain { get => _Chain; set => _Chain = value; }
        public string TypesofWheels1 { get => TypesofWheels; set => TypesofWheels = value; }
        public int NumberofGears { get => _numberofGears; set => _numberofGears = value; }
        public string Frame { get => _frame; set => _frame = value; }
        public string Pedals { get => _pedals; set => _pedals = value; }
        public string Handel { get => _handel; set => _handel = value; }
        public int NumberofSeats { get => _numberofSeats; set => _numberofSeats = value; }
        public string UniqueSerial { get => _uniqueSerial; set => _uniqueSerial = value; }


        //Methods
        



    }

    
}