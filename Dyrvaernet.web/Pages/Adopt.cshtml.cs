using Microsoft.AspNetCore.Mvc.RazorPages;
using Dyreinternat.Domain.Models;
using Dyreinternat.Domain.Interfaces;
using System.Collections.Generic;
namespace DyrvaernetRoskilde.Pages;

public class AdoptModel : PageModel
{
    private readonly IAnimalRepository _animalRepository;

    public AdoptModel(IAnimalRepository animalRepository)
    {
        _animalRepository = animalRepository;
    }

    public List<Animal> Animals { get; set; }

    public void OnGet()
    {
        Animals = _animalRepository.GetAll();
    }
}