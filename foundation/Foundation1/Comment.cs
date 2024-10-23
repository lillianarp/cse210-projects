
public class Comment 
{
    // attributes

    private string _commenterName;
    private string _text;

    // constructor

    public Comment(string commenterName, string text)
    {
        _commenterName = commenterName;
        _text = text; 
    }

    // methods

    public string GetCommentDetails()
    {
        return $"{_commenterName}: {_text}"; 
    }

}