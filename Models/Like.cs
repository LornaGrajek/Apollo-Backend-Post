namespace Models;

public class Like{
    public int Id { get; set; }
    public int PostId { get; set; }
    public int CommentId { get; set; }
    public int Amount { get; set; }
    public string? UserName { get; set; }
}