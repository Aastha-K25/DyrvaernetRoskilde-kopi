using Microsoft.AspNetCore.Mvc.RazorPages;
using Dyreinternat.Domain.Models;
using Dyreinternat.Domain.Interfaces;
using System.Collections.Generic;
namespace DyrvaernetRoskilde.Pages;

public class AdoptModel : PageModel
{
    private readonly IAnimalRepository _adoptRepository;

    public AdoptModel(IAnimalRepository animalRepository)
    {
        _adoptRepository = animalRepository;
    }

    public List<Animal> Animals { get; set; }

    public void OnGet()
    {
        Animals = _adoptRepository.GetAll();
    }
}


