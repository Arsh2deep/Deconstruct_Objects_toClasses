namespace Deconstruct_Objects_toClasses
{
    public class SunGlasses
    {
        //Feilds
        string _Lenses;
        string _frames;
        string _NosePad;
        string _Hinges;
        string _Arms;
        string _EarPeice;


        //Constructor
        public SunGlasses(string lenses, string frames, string nosePad, string hinges, string arms, string earPeice)
        {
            _Lenses = lenses;
            _frames = frames;
            _NosePad = nosePad;
            _Hinges = hinges;
            _Arms = arms;
            _EarPeice = earPeice;
        }

        //Properties
        public string Lenses { get => _Lenses; set => _Lenses = value; }
        public string Frames { get => _frames; set => _frames = value; }
        public string NosePad { get => _NosePad; set => _NosePad = value; }
        public string Hinges { get => _Hinges; set => _Hinges = value; }
        public string Arms { get => _Arms; set => _Arms = value; }
        public string EarPeice { get => _EarPeice; set => _EarPeice = value; }
    }
}