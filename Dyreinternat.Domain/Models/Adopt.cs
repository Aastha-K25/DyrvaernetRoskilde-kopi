namespace Dyreinternat.Domain.Models;

public class Adopt : Animal
{
    public int Id { get; set; }  
    public bool IsSterilized { get; set; }
    public string Location { get; set; } 
    public bool HasValidPassport { get; set; } // Gyldig pas
    public string ImageUrl { get; set; } // Billede af hunden
    public bool IsAvailable { get; set; } // tilgængelig
}



