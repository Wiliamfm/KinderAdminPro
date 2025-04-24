namespace KindlerAdminPro.Payroll.Domain.Entities;

public class Employee
{
  public Guid Id { get; set; }
  public Guid UserId { get; set; }
  public required string Name { get; set; }
  public Guid JobId { get; set; }
  public required Job Job { get; set; }
}
