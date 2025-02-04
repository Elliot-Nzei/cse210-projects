// to store video details and comments
class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; } 
    private List<Comment> comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
    }

    // add a comments
    public void AddComment(string userName, string text)
    {
        comments.Add(new Comment(userName, text));
    }

    // return the number of comments
    public int GetCommentCount()
    {
        return comments.Count;
    }

    // display video details
    public void Display()
    {
        Console.WriteLine($"Title: {Title}\nAuthor: {Author}\nLength: {Length} seconds");
        Console.WriteLine($"Number of Comments: {GetCommentCount()}");
        Console.WriteLine("Comments:");
        foreach (var comment in comments)
        {
            Console.WriteLine($"- {comment.UserName}: {comment.Text}");
        }
        Console.WriteLine("\n--------------------\n");
    }
}