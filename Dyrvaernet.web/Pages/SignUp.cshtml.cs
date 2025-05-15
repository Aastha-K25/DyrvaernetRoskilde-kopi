using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using Dyreinternat.Domain.Interfaces;
using Dyreinternat.Domain.Models;
using Dyreinternat.Infrastructure.Repositories;

namespace DyrvaernetRoskilde.Pages;

public class SignUpModel : PageModel
{
    public string FullName { get; set; }
    public int EventId { get; set; }

    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
        SignUp s = new SignUp();
        s.FullName = FullName;
        s.EventId = EventId;
        
        SignUpRepository repo=new SignUpRepository();
        repo.Add(s);
        
        return RedirectToPage("./Thanks");
    }
}