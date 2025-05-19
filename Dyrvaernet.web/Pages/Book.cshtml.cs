using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dyreinternat.Domain.Models;
using Dyreinternat.Infrastructure.Repositories;
using System.Collections.Generic;
    
namespace DyrvaernetRoskilde.Pages;

public class BookModel : PageModel
{
    private static BookRepository _bookRepo = new BookRepository();
    
  [BindProperty]  
    public Book NyBooking { get; set; }
    
    public List<Book> Books { get; set; }
    public void OnGet()
    {
        Books = _bookRepo.GetAll();
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            Books = _bookRepo.GetAll();
            return Page();
        }

        int nyId = _bookRepo.GetAll().Count + 1;
        NyBooking.Id = nyId;
        _bookRepo.Add(NyBooking);

        return RedirectToPage("BookingBekraeftelse");
    }
}