namespace KindlerAdminPro.Enrollment.Domain.Entities;

public class Grade
{
  public Guid Id { get; set; }
  public required string Name { get; set; }
  public required string Description { get; set; }
}
