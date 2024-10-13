
// _text : string
// _isHidden : bool 

public class Word{

    private string _text = "";
    private bool _isHidden; 

    // constructor -> Word(text : string) (takes one parameter)

    public Word(string text) // this is a constructor - so no return type, not even void; initializes the object's state
    {
        _text = text;
        _isHidden = false; // because this object is not hidden at the beginning
    }

    // how CAN this class behave? 
    public void Hide()
    {
        _isHidden = true; // this toggle is on, so the word is hidden - action method
    }

    public void Show()
    {
        _isHidden = false; // and now it's off, so the word is visible - action method 
    }

    public bool IsHidden()
    {
        return _isHidden; // this is a getter method; it doesn't change the state, it just reports on whether the state is true or not
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length); 
        }
        else
        {
            return _text; // return the actual word
        }
    }

}