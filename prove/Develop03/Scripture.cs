
// _reference : Reference 
// _words : List<Word>

using System.Security.Cryptography;

public class Scripture
{

    // attributes

    private Reference _reference;
    private List<Word> _words; 

    // constructor

    public Scripture(Reference Reference, string text) // not even 'void'
    {
        _reference = Reference;
        _words = new List<Word>(); // initialize with 'new'

        string[] wordList = text.Split(' '); // take the text (the scripture) and split into individual words
        foreach(string wordText in wordList)
        {
            Word word = new Word(wordText);
            _words.Add(word); // string the individual word obects (words) together in the wordList
        }

    }

    // behaviours

    public void HideRandomWords()
    {
        if (IsCompletelyHidden()) // check that words are visible before trying to hide them 
        {
            return;
        }

        Random random = new Random();
        int visibleWordCount = _words.Count(word => !word.IsHidden());
        int numberToHide = random.Next(1, Math.Min(visibleWordCount + 1, 6));

        int hiddenWords = 0; 

        while (hiddenWords < numberToHide)
        {
            int randomIndex = random.Next(0, _words.Count); // select random word position (index)
            Word word = _words[randomIndex];

            if (!word.IsHidden())
            {
                word.Hide(); 
                hiddenWords++; 
            }

        }

    }

    public string GetDisplayText()
    {
        string displayText = "";

        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }

        return displayText.Trim(); 
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if(!word.IsHidden()) 
            {
                return false;
            }
        }

        return true;
    }

    public Reference GetReference()
    {
        return _reference;
    }
}