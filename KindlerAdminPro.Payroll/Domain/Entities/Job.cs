namespace KindlerAdminPro.Payroll.Domain.Entities;

public class Job
{
  public Guid Id { get; set; }
  public required string Name { get; set; }
  public decimal Salary { get; set; }
}
