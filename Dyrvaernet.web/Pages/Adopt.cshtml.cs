using Microsoft.AspNetCore.Mvc.RazorPages;
using Dyreinternat.Domain.Models;
using Dyreinternat.Domain.Interfaces;
using System.Collections.Generic;
namespace DyrvaernetRoskilde.Pages;

public class AdoptModel : PageModel
{
    private readonly IAdoptRepository _adoptRepository;

    public AdoptModel(IAdoptRepository adoptRepository)
    {
        _adoptRepository = adoptRepository;
    }

    public List<Adopt> Adopts { get; set; }

    public void OnGet()
    {
        Adopts = _adoptRepository.GetAll();
    }
}




