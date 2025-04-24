namespace KindlerAdminPro.Enrollment.Domain.Entities;

public class Guardian
{
  public Guid Id { get; set; }
  public required string Name { get; set; }
  public required string DocumentNumber { get; set; }
  public required string Phone { get; set; }
  public required string Profession { get; set; }
  public required string Company { get; set; }
  public required string Email { get; set; }
  public required string Address { get; set; }
  public required string TypeId { get; set; }
}
