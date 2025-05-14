using System.Collections.Generic;
using Dyreinternat.Domain.Models;

namespace Dyreinternat.Domain.Interfaces;

    public interface IAnimalRepository
    {
        List<Animal> GetAll();
        Animal GetById(int id);
        void Add(Animal animal);
        void Update(Animal animal);
    }
