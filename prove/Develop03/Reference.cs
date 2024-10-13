
// _book : string
// _chapter : int
// _verse : int
// _endVerse : int 

public class Reference
{
    // attributes

    private string _book = "";
    private int _chapter;
    private int _verse;
    private int _endVerse;  

    // constructors

    public Reference(string book, int chapter, int verse) // single verse
    {
        _book = book;
        _chapter = chapter; 
        _verse = verse;
    }
    
    public Reference(string book, int chapter, int startVerse, int endVerse = 0) // multiple verse
    {
        _book = book;
        _chapter = chapter; 
        _verse = startVerse;
        _endVerse = endVerse;
    }
    
    // behaviours

    public string GetDisplayText() // if only 1 verse, return 1 reference; if more than one verse, format for multi-verses
    {
        if (_endVerse == 0) // single verse reference 
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else // multiple verse reference
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }


}