
using System.Collections.Generic; 

public class Video {

    // attributes

    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments; 

    // constructor

    public Video(string title, string author, int length) 
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>(); // empty list 
    }

    // methods

    // add a comment to the video 
    public void AddComment(Comment comment) 
    {
        _comments.Add(comment);
    }

    // how many comments?
    public int GetCommentCount() 
    {
        return _comments.Count;
    }

    // display video info
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of Comments: {GetCommentCount()}");
        
        // get all the comments
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"- {comment.GetCommentDetails()}");
        }

    }

}

