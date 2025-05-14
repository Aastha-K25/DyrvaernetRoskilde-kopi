using System;
using System.Collections.Generic;
using Dyreinternat.Domain.Models;
using Dyreinternat.Domain.Interfaces;
using Dyreinternat.Infrastructure.Repositories;
namespace Dyreinternat.ConsoleApp;


class Program
{
    static void Main()
    {
        IAnimalRepository repository = new AnimalRepository();

        Console.WriteLine("Dyr til adoption:");
        List<Animal> allAnimals = repository.GetAll();

        for (int i = 0; i < allAnimals.Count; i++)
        {
            Animal a = allAnimals[i];
            Console.WriteLine(a.Name + " (" + a.Species + "), født: " + a.BirthYear);
        }

        Animal newAnimal = new Animal();
        newAnimal.Id = 2;
        newAnimal.Name = "Luna";
        newAnimal.Species = "Hund";
        newAnimal.BirthYear = 2019;
        newAnimal.ChipNumber = "789012";
        newAnimal.HealthNotes = "Vaccination";
        newAnimal.NeedsMedicalAttention = false;

        repository.Add(newAnimal);

        Console.WriteLine("\nOpdateret liste:");
        foreach (Animal a in repository.GetAll())
        {
            Console.WriteLine(a.Name + " (" + a.Species + ")");
        }
    }
}
