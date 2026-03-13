using Recommenda.Domain.Commons;

namespace Recommenda.Domain.Entities;

public class UserConfiguration(Guid userId) : BaseEntity
{
    public string Theme { get; private set; } = "Dark"; //Dark Light

    public bool EnableNotifications { get; private set; } = false;
    
    //1..1
    public Guid UserId { get; private set; } = userId;
}