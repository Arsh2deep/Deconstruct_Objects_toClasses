namespace Deconstruct_Objects_toClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bicycle bicycle = new Bicycle();
            Bicycle bicycle2 = new Bicycle();
            Bicycle bicycle3 = bicycle2;

            Console.WriteLine($"Bicycle {bicycle}");
            Console.WriteLine($"Bicycle2 {bicycle2}");
            Console.WriteLine($"Bicycle3 {bicycle3}");

            PlayingCards playingCards = new PlayingCards();

            SunGlasses sunglasses = new SunGlasses();

            Umbrella umbrella = new Umbrella();

            NoteBook noteBook = new NoteBook();

        }//Main

    }//Class

}//Namespace
