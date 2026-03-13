using Recommenda.Domain.Commons;

namespace Recommenda.Domain.Entities;

public class Rating : BaseEntity 
{
    public Guid ContentId { get; private set; }

    public Guid UserId { get; private set; }

    public int Score { get; private set; }

    public Rating(Guid contentId, Guid userId, int score)
    {
        ContentId = contentId;
        UserId = userId;
        UpdateScore(score);
    }

    //CamelCase
    public void UpdateScore(int score /*snackCase*/)
    {
        if (score is < 1 or > 5) throw new Exception("The score cannot be less than 1 or greater than 5");
        Score = score;
    }
    
}