using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using Dyreinternat.Domain.Models;
using Dyreinternat.Infrastructure.Repositories;

namespace DyrvaernetRoskilde.Web.Pages;

public class EventsModel : PageModel
{
   public List<Event> Events = new List<Event>();

   public void OnGet()
   {
      EventRepository repo = new EventRepository();
      Events = repo.GetAll();
   }
}