namespace KindlerAdminPro.Identity.Domain.Entities;

public class Role
{
  public int Id { get; set; }
  public required string Name { get; set; }
  public required string Description { get; set; }
}
