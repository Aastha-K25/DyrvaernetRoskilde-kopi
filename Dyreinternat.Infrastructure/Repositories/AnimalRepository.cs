using System.Collections.Generic;
using Dyreinternat.Domain.Models;
using Dyreinternat.Domain.Interfaces;
namespace Dyreinternat.Infrastructure.Repositories;

public class AnimalRepository : IAnimalRepository
{
    private List<Animal> animals = new List<Animal>();

    public AnimalRepository()
    {
        Animal animal1 = new Animal();
        animal1.Id = 1;
        animal1.Name = "Milo";
        animal1.Species = "Kat";
        animal1.BirthYear = 2020;
        animal1.ChipNumber = "123456";
        animal1.HealthNotes = "Brækket ben";
        animal1.NeedsMedicalAttention = true;

        animals.Add(animal1);
    }

    public List<Animal> GetAll()
    {
        return animals;
    }

    public Animal GetById(int id)
    {
        foreach (Animal animal in animals)
        {
            if (animal.Id == id)
            {
                return animal;
            }
        }
        return null;
    }

    public void Add(Animal animal)
    {
        animals.Add(animal);
    }

    public void Update(Animal updatedAnimal)
    {
        for (int i = 0; i < animals.Count; i++)
        {
            if (animals[i].Id == updatedAnimal.Id)
            {
                animals[i] = updatedAnimal;
            }
        }
    }
}
