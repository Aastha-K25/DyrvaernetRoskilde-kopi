using System;
using System.Collections.Generic;
using Dyreinternat.Domain.Models;
using Dyreinternat.Domain.Interfaces;
using Dyreinternat.Infrastructure.Repositories;
namespace Dyreinternat.ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        IAdoptRepository repository = new AdoptRepository();
        List<Adopt> dogs = repository.GetAll();
        
        Console.WriteLine("---- Liste over hunde til adoption ----\n"); // Bindestreg = Mellemrum
        
        foreach (Adopt Adopt in dogs)
        {
            Console.WriteLine("navn: " + Adopt.Name);
            Console.WriteLine("Race: " + Adopt.Breed);
            Console.WriteLine("Farve: " + Adopt.Color);
            Console.WriteLine("Køn: " + Adopt.Gender);
            Console.WriteLine("vægt: " + Adopt.Weight + " kg");
            Console.WriteLine("Alder: " + Adopt.Age + " år");
            Console.WriteLine("Steriliseret: " + (Adopt.IsSterilized ? "Ja" : "Nej"));
            Console.WriteLine("Placering: " + Adopt.Location);
            Console.WriteLine("Gyldig pas: " + (Adopt.HasValidPassport ? "Ja" : "Nej"));
            Console.WriteLine("Tilgængelig: " + (Adopt.IsAvailable ? "Ja" : "Nej"));
            Console.WriteLine("billede: " + Adopt.ImageUrl);
            Console.WriteLine("Book en tid: ring til internatet for mere info");
            Console.WriteLine("----------------------------------------\n"); // Bindestreg så der er mmellemrum i hvert hund
        }
    }
}

