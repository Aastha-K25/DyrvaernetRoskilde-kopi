namespace Dyreinternat.Domain.Models;

public class Animal
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Species { get; set; }
    public int BirthYear { get; set; }
    public string ChipNumber { get; set; }
    public string HealthNotes { get; set; }
    public bool NeedsMedicalAttention { get; set; }
}
