using System;

public class Scripture
{
    public Reference _reference;
    public List<Word> _words;

public Scripture(Reference reference, string text)
{
    _reference = reference;
    _words = text.Split("").Select(word => new Word(word)).ToList();

}
public void HideRandomWords(int numberToHide)
{
    var visibleWords = _words.Where(word => !word.IsHidden()).ToList();
    if (!visibleWords.Any()) return;

    var random = new Random();
    foreach(var word in visibleWords.Order(_ => random.Next()).Take(numberToHide))
    {
        word.Hide();
    }

}
public string GetDisplayText()
{
    return $"{_reference.GetDisplayText()}\n{string.Join(" ", _words.Select(word => word.GetDisplayText()))}";

}
public bool IsCompletelyHidden()
{
    return _words.All(word => word.IsHidden());
}
}


