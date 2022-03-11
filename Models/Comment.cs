namespace Models;

public class Comment{
    public int Id { get; set; }
    public int PostId { get; set; }
    public int TotalLikes { get; set; }
    public string? UserName { get; set; }
    public DateTimeKind DateTime { get; set; }
    public List<Like>? Likes { get; set; }
}