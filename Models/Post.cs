global using Microsoft.EntityFrameworkCore;
namespace Models;

public class Post{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Story { get; set; }
    public string? UserName { get; set; }
    public int CurrentUserId { get; set; }
    public int TotalLikes { get; set; }
    public DateTimeKind DateTime { get; set; }
    public List<Comment>? Comments { get; set; }
    public int GroupPostId { get; set; }
}