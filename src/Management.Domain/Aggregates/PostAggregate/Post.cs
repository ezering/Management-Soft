using Management.Domain.Aggregates.UserProfileAggregate;

namespace Management.Domain.Aggregates.PostAggregate;

public class Post
{
    public Guid PostId { get; private set; }
    public Guid UserProfileId { get; private set; }
    public UserProfile UserProfile { get; private set; }
    public string TextContent { get; private set; }

    public IEnumerable<PostComment> Comments => _comments;

    public IEnumerable<PostInteraction> Interactions => _interactions;

    public DateTime CreatedDate { get; private set; }
    public DateTime LastModifiedDate { get; private set; }
    private readonly List<PostComment> _comments = new List<PostComment>();
    private readonly List<PostInteraction> _interactions = new List<PostInteraction>();
    private Post() { }

    // Factory method
    public static Post CreatePost(Guid userProfileId, string textContent)
    {
        // TODO: ADD VALIDATION, ERROR HANDLING STRATEGIES, ERROR NOTIFICATION STRATEGIES
        return new Post
        {
            UserProfileId = userProfileId,
            TextContent = textContent,
            CreatedDate = DateTime.UtcNow,
            LastModifiedDate = DateTime.UtcNow
        };
    }
    
    // public methods
    public void UpdatePostTextContent(string newText)
    {
        newText = newText;
        LastModifiedDate = DateTime.UtcNow;
    }
    
    public void addPostComment(PostComment postComment)
    {
        _comments.Add(postComment);
    }
    
    public void removePostComment(PostComment postComment)
    {
        _comments.Remove(postComment);
    }
    
    public void addPostInteraction(PostInteraction postInteraction)
    {
        _interactions.Add(postInteraction);
    }
    
    public void removePostInteraction(PostInteraction postInteraction)
    {
        _interactions.Remove(postInteraction);
    }

}