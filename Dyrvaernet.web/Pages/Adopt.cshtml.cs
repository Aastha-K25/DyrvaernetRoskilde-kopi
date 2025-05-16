using Microsoft.AspNetCore.Mvc.RazorPages;
using Dyreinternat.Domain.Models;
using Dyreinternat.Domain.Interfaces;
using System.Collections.Generic;
namespace DyrvaernetRoskilde.Pages;

public class AdoptModel : PageModel
{
    private readonly IAdoptRepository _repository;

    public AdoptModel(IAdoptRepository adoptRepository)
    {
        _repository = adoptRepository;
    }

    public List<Dyreinternat.Domain.Models.Adopt> Adopts { get; set; }
    public List<Adopt> Adopt { get; set; }

    public void OnGet()
    {
        Adopts = _repository.GetAll();
    }
}




