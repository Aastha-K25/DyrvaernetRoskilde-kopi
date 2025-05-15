using System;
using System.Collections.Generic;
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
      e1.Description = "Gå en tur med hundene";
      e1.Date = DateTime.Today.AddDays(1);

      Event e2 = new Event();
      e2.Id = 2;
      e2.Title = "Kat efter musen";
      e2.Description = "Leg med kattene";
      e2.Date = DateTime.Today.AddDays(1);

      events.Add(e1);
      events.Add(e2);
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


