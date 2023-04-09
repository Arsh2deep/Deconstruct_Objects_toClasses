namespace Deconstruct_Objects_toClasses
{
    public class Umbrella
    {
        //Feilds
        string _Canopy;
        string _MetalRibs;
        string _Shaft;
        string _Handle;
        string _Spring;
        string _RunnerButton;

        //Constructor
        public Umbrella(string canopy, string metalRibs, string shaft, string handle, string spring, string runnerButton)
        {
            _Canopy = canopy;
            _MetalRibs = metalRibs;
            _Shaft = shaft;
            _Handle = handle;
            _Spring = spring;
            _RunnerButton = runnerButton;
        }

        //Properties
        public string Canopy { get => _Canopy; set => _Canopy = value; }
        public string MetalRibs { get => _MetalRibs; set => _MetalRibs = value; }
        public string Shaft { get => _Shaft; set => _Shaft = value; }
        public string Handle { get => _Handle; set => _Handle = value; }
        public string Spring { get => _Spring; set => _Spring = value; }
        public string RunnerButton { get => _RunnerButton; set => _RunnerButton = value; }
    }
}