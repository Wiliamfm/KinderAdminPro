namespace KindlerAdminPro.Enrollment.Domain.Entities;

public class Student
{
  public Guid Id { get; set; }
  public required string FullName { get; set; }
  public DateTime BirthDate { get; set; }
  public required string BirthPlace { get; set; }
  public required string Department { get; set; }
  public required string DocumentNumber { get; set; }
  public double Weight { get; set; }
  public double Height { get; set; }
  public required string BloodType { get; set; }
  public required string SocialSecurity { get; set; }
  public ICollection<string> Allergies { get; set; } = [];
  public string? GradeId { get; set; }
  public ICollection<string> GuardianIds { get; set; } = [];
  public ICollection<Guardian> Guardians { get; set; } = [];
}
