using System.Collections.Generic;
using Dyreinternat.Domain.Interfaces;
using Dyreinternat.Domain.Models;


namespace Dyreinternat.Infrastructure.Repositories
{
    public class AdoptRepository : IAdoptRepository
    {
        private List<Adopt> adopts = new List<Adopt>()
        {
            new Adopt
            {
                Id = 1,

                Name = "Coco",
                Breed = "Cocker Spaniel",
                Color = "Brun",
                Gender = "Han",
                Weight = 16,
                Age = 4,
                IsSterilized = false,
                Location = "Sjælland",
                HasValidPassport = true,
                ImageUrl = "/Images/imgg1.png",
                IsAvailable = true
            },
            new Adopt
            {
                Id = 2,

                Name = "Mano",
                Breed = "Labrador",
                Color = "Gul",
                Gender = "Han",
                Weight = 29,
                Age = 3,
                IsSterilized = false,
                Location = "Sjælland",
                HasValidPassport = true,
                ImageUrl = "/Images/imgg2.png",
                IsAvailable = true
            },
            new Adopt
            {
                Id = 3,

                Name = "Zoro",
                Breed = "Hyrdehunde-blanding",
                Color = "Hvid/Sort/Brun",
                Gender = "Hun",
                Weight = 20,
                Age = 2,
                IsSterilized = true,
                Location = "Sjælland",
                HasValidPassport = false,
                ImageUrl = "/Images/imgg3.png",
                IsAvailable = true
            },
            new Adopt
            {
                Id = 4,

                Name = "Pedro",
                Breed = "Hyrdehunde-blanding",
                Color = "Hvid/Fawn/Brun",
                Gender = "Han",
                Weight = 20,
                Age = 1,
                IsSterilized = false,
                Location = "Sjælland",
                HasValidPassport = false,
                ImageUrl = "/Images/imgg4.png",
                IsAvailable = true
            },
            new Adopt
            {
                Id = 5,
                
                Name = "Newton",
                Breed = "Huskat",
                Color = "Brunstribet",
                Gender = "Han",
                Weight = 4,
                Age = 2,
                IsSterilized = false,
                Location = "Sjælland",
                ImageUrl = "/Images/Cat1.png",
                IsAvailable = true
            },
            new Adopt
            {
                Id = 6,
                
                Name = "Mia",
                Breed = "British Shorthair",
                Color = "Silver Tabby",
                Gender = "Hun",
                Weight = 4,
                Age = 3,
                IsSterilized = true,
                Location = "Sjælland",
                ImageUrl = "/Images/Cat2.png",
                IsAvailable = true
            },
            new Adopt
            {
                Id = 7,
                
                Name = "Ponyo",
                Breed = "Huskat",
                Color = "Brun/Gråstribet",
                Gender = "Hun",
                Weight = 4,
                Age = 2,
                IsSterilized = true,
                Location = "Sjælland",
                ImageUrl = "/Images/Cat3.png",
                IsAvailable = true
            },
            new Adopt
            {
                Id = 8,
                
                Name = "Mynthe",
                Breed = "Dværgvædder",
                Color = "Brun/Hvid",
                Gender = "Hun",
                Weight = 2,
                Age = 2,
                Location = "Sjælland",
                ImageUrl = "/Images/Kanin.png",
                IsAvailable = true
            },
            new Adopt
            {
                Name = "Kinder",
                Breed = "Dværgvædder",
                Color = "Hvid/Sort",
                Gender = "Hun",
                Weight = 2,
                Age = 3,
                Location = "Sjælland",
                ImageUrl = "/Images/Kanin2.png",
                IsAvailable = true
            }
        };

        public List<Adopt> GetAll()
        {
            return adopts;
        }

        public Adopt GetById(int id)
        {
            foreach (Adopt adopt in adopts)
            {
                if (adopt.Id == id)
                {
                    return adopt;
                }
            }
            return null;
        }

        public List<Adopt> SearchByBreed(string breed)
        {
            List<Adopt> result = new List<Adopt>();
            foreach (Adopt adopt in adopts)
            {
                if (adopt.Breed.ToLower().Contains(breed.ToLower()))
                {
                    result.Add(adopt);
                }
            }
            return result;
        }
    }
}