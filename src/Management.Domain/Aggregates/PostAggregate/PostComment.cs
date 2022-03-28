namespace Management.Domain.Aggregates.PostAggregate;

public class PostComment
{
    public int CommentId { get; private set; }
    public int PostId { get; private set; }
    public string Text { get; private set; }
    public Guid UserProfileId { get; private set; }
    public DateTime CreatedDate { get; private set; }
    public DateTime LastModified { get; private set; }
    
    private PostComment() {}
    
    public static PostComment CreatePostComment(int postId, string text, Guid userProfileId)
    {
        // TODO: ADD VALIDATION, ERROR HANDLING STRATEGIES, ERROR NOTIFICATION STRATEGIES
        return new PostComment
        {
            PostId = postId,
            Text = text,
            UserProfileId = userProfileId,
            CreatedDate = DateTime.UtcNow,
            LastModified = DateTime.UtcNow
        };
    }

    // public methods
    public void UpdatePostComment(string text)
    {
        Text = text;
        LastModified = DateTime.UtcNow;
    }
}