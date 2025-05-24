using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using Dyreinternat.Domain.Models;
using Dyreinternat.Domain.Interfaces;

namespace Dyreinternat.Infrastructure.Repositories;

public class EventRepository : IEventRepository
{
   private List<Event> events = new List<Event>();

   public EventRepository()
   {
      Event e1 = new Event();
      e1.Id = 1;
      e1.Title = "Fælles hundeluftning";
      e1.Description = "Tag med på en hyggelig gåtur med nogle af vores søde og energiske hunde fra Roskilde Dyreværnet. Det er en god måde at lære hundene at kende på, give dem motion og samtidig nyde naturen sammen med andre dyrevenner.";
      e1.Date = DateTime.Today.AddDays(1);
      e1.ImagePath = "/Images/Hund.png";

      Event e2 = new Event();
      e2.Id = 2;
      e2.Title = "Kat efter musen";
      e2.Description = "Kom og vær med til en sjov og hyggelig stund, hvor vi leger med kattene her på Roskilde Dyreværnet. Det er en fantastisk mulighed for at lære kattene at kende, aktivere dem og måske finde dit nye kæledyr.";
      e2.Date = DateTime.Today.AddDays(2);
      e2.ImagePath = "/Images/Kat.png";

      Event e3 = new Event();
      e3.Id = 3;
      e3.Title = "Sommerfest";
      e3.Description = "Deltag i vores årlige sommerfest! Uanset om du er besøgende, frivillig eller bare nysgerrig, er du velkommen til en hyggelig dag med dyr, mad og aktiviteter.";
      e3.Date = DateTime.Today.AddDays(3);
      e3.ImagePath = "/Images/Somms$erfest.png";

      Event e4 = new Event();
      e4.Id = 4;
      e4.Title = "Lær om adoption og dyrene";
      e4.Description = "Er du nysgerrig på, hvordan det fungerer at adoptere et dyr? " +
                       "Kom og hør om vores arbejde med katte og hunde, og få indblik i hele adoptionsprocessen. " +
                       "Du får også mulighed for at møde nogle af vores dyr og stille spørgsmål undervejs.";
      e4.Date = DateTime.Today.AddDays(4);
      e4.ImagePath = "/Images/SPG.png";
      
      events.Add(e1);
      events.Add(e2);
      events.Add(e3);
      events.Add(e4);
   }

   public List<Event> GetAll()
   {
      return events;
   }

   public Event GetById(int id)
   {
      for (int i = 0; i < events.Count; i++)
      {
         if (events[i].Id == id)
         {
            return events[i];
         }
      }

      return null;
   }
}


