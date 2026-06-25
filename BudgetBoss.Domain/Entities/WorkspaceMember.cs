namespace BudgetBoss.Domain.Entities;

public class WorkspaceMember : HardDeleteBaseEntity
{
    public Guid UserId { get; set; }

    public Guid WorkspaceId { get; set; }
}
