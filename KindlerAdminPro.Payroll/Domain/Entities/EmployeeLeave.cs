namespace KindlerAdminPro.Payroll.Domain.Entities;

public class EmployeeLeave
{
  public Guid Id { get; set; }
  public Guid EmployeeId { get; set; }
  public required Employee Employee { get; set; }
  public DateTimeOffset StartDate { get; set; }
  public DateTimeOffset EndDate { get; set; }
  public required string Reason { get; set; }
  public bool IsApproved { get; set; }
}
