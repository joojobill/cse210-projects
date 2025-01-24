using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

public Reference()
{
    _book = "";
    _chapter = 0;
    _verse = 0;
    _endVerse = 0;
}
public Reference(string Book, int Chapter, int StartVerse)
{
    _book = Book;
    _chapter = Chapter;
    _verse = StartVerse;


}
public Reference(string Book, int Chapter, int StartVerse, int EndVerse)
{
    _book = Book;
    _chapter = Chapter;
    _verse = StartVerse;
    _endVerse = EndVerse;
}

public string GetDisplayText()
{
    return _endVerse > 0 ? $"{_book} {_chapter} : {_verse}- {_endVerse}" : $"{_book} {_chapter}:{_verse}";
    
}

}