namespace Deconstruct_Objects_toClasses
{
    public class NoteBook
    {
        //Feilds
        string _BookCover;
        int _NumOfPages;
        string _Binding;
        string _Bookmark;
        string _closure;


        //Constructor
        public NoteBook(string bookCover, int numOfPages, string binding, string bookmark, string closure)
        {
            _BookCover = bookCover;
            _NumOfPages = numOfPages;
            _Binding = binding;
            _Bookmark = bookmark;
            _closure = closure;
        }

        //Properties
        public string BookCover { get => _BookCover; set => _BookCover = value; }
        public int NumOfPages { get => _NumOfPages; set => _NumOfPages = value; }
        public string Binding { get => _Binding; set => _Binding = value; }
        public string Bookmark { get => _Bookmark; set => _Bookmark = value; }
        public string Closure { get => _closure; set => _closure = value; }
    }
}