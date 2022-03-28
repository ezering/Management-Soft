namespace Management.Domain.Aggregates.PostAggregate;

public class PostInteraction
{
    public Guid InteractionId { get; private set; }
    public Guid PostId { get; private set; }
    public InteractionType InteractionType { get; private set; }
    
    private PostInteraction() {}
    
    // factory method
    public static PostInteraction CreatePostInteraction(Guid postId)
    {
        // TODO: ADD VALIDATION, ERROR HANDLING STRATEGIES, ERROR NOTIFICATION STRATEGIES
        return new PostInteraction
        {
            PostId = postId,
            InteractionId = Guid.NewGuid()
        };
    }
}