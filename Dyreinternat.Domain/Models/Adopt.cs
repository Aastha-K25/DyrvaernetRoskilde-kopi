namespace Dyreinternat.Domain.Models;

public class Adopt
{
    public int Id { get; set; }  
    public string Name { get; set; } 
    public string Breed { get; set; } // Race
    public string Color { get; set; } 
    public string Gender { get; set; }
    public double Weight { get; set; }
    public int Age { get; set; }
    public bool IsSterilized { get; set; }
    public string Location { get; set; } 
    public bool HasValidPassport { get; set; } // Gyldig pas
    public string ImageUrl { get; set; } // Billede af hunden
    public bool IsAvailable { get; set; } // tilgængelig
}



