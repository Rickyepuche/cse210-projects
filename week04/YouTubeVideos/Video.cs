using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using System.Transactions;

public class Video
{
    //attributes
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public void SetVideoComment(string name, string text)
    {
        Comment c = new Comment(name, text);
        _comments.Add(c);
    }
    //methods
    public int GetCommentCount()
    {
        int count = 0;
        foreach (Comment com in _comments)
        {
            count++;
        }
        return count;
    }
    public void DisplayVideoInfo()
    {

        Console.WriteLine($"Video: {_title}\nAuthor: {_author}\nLength: {_length} seconds\nNumber of comments: {GetCommentCount()}\nComments:");
        foreach (Comment com in _comments)
        {
            Console.WriteLine($"-{com.DisplayComment()}");
        }
    }
}