namespace KindlerAdminPro.Enrollment.Domain.Entities;

public class GuardianType
{
  public Guid Id { get; set; }
  public required string Name { get; set; }
  public required string DisplayName { get; set; }
  public required string Description { get; set; }
}
