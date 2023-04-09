namespace Deconstruct_Objects_toClasses
{
    public class PlayingCards
    {
        //Feilds
        enum TypesOfCards { clubs, Hearts, Spades, Diamonds }
        string _cardPaper;
        int _numberofCards;
        string _cardBox;
        string _colorOfCard;
        double _sizeOfCard;


        //Constructor
        public PlayingCards(string cardPaper, int numberofCards, string cardBox, string colorOfCard,double sizeOfCard)
        {
            _cardPaper = cardPaper;
            _numberofCards = numberofCards;
            _cardBox = cardBox;
            _colorOfCard = colorOfCard;
            _sizeOfCard = sizeOfCard;
        }


        //Properties
        public string CardPaper { get => _cardPaper; set => _cardPaper = value; }
        public int NumberofCards { get => _numberofCards; set => _numberofCards = value; }
        public string CardBox { get => _cardBox; set => _cardBox = value; }
        public string ColorOfCard { get => _colorOfCard; set => _colorOfCard = value; }
        public double SizeOfCard { get => _sizeOfCard; set => _sizeOfCard = value; }
    }
}