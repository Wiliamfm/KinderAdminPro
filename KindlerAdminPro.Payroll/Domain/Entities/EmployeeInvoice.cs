namespace KindlerAdminPro.Payroll.Domain.Entities;

public class EmployeeInvoice
{
  public Guid Id { get; set; }
  public Guid EmployeeId { get; set; }
  public required Employee Employee { get; set; }
  public DateTimeOffset CreatedAt { get; set; }
  public required string Path { get; set; }
  public required string FileName { get; set; }
}
