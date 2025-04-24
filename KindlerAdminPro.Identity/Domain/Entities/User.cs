namespace KindlerAdminPro.Identity.Domain.Entities;

public class User
{
  public Guid Id { get; set; }
  public required string Email { get; set; }
  public required string Password { get; set; }
  public Guid RoleId { get; set; }
  public required Role Role { get; set; }
}
