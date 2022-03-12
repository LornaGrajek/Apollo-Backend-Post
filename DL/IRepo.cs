global using Models;
namespace DL;
public interface IRepo{
    //----------------Posts---------------
    List<Post> GetAllPosts();
    List<Post> GetAllPostsByGroupId(int groupId);
    Post GetPostById(int id);
    void AddPost(Post postToAdd);
    void DeletePost(int id);
    void UpdatePost(int id);

    //----------------Comment-------------
    List<Comment> GetAllCommentsByPostId(int id);
    Comment GetCommentById(int id);
    void AddComment(Comment commentToAdd);
    void DeleteComment(int id);
    void UpdateComment(int id);

    //---------------Likes---------------------
    void AddLikeToPost(int postId);
    void AddLikeToComment(int commentId);
    void RemoveLikeFromPost(int postId);
    void RemoveLikeFromComment(int commentId);
}