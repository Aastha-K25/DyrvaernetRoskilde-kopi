using System;
using System.Collections.Generic;
using Dyreinternat.Domain.Models;
using Dyreinternat.Domain.Interfaces;
using Dyreinternat.Infrastructure.Repositories;
namespace Dyreinternat.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // adoption 
            IAdoptRepository adoptRepository = new AdoptRepository();
            List<Adopt> dogs = adoptRepository.GetAll();

            Console.WriteLine("---- Liste over dyre til adoption ----\n");

            foreach (Adopt adopt in dogs)
            {
                Console.WriteLine("Navn: " + adopt.Name);
                Console.WriteLine("Race: " + adopt.Breed);
                Console.WriteLine("Farve: " + adopt.Color);
                Console.WriteLine("Køn: " + adopt.Gender);
                Console.WriteLine("Vægt: " + adopt.Weight + " kg");
                Console.WriteLine("Alder: " + adopt.Age + " år");
                Console.WriteLine("Steriliseret: " + (adopt.IsSterilized ? "Ja" : "Nej"));
                Console.WriteLine("Placering: " + adopt.Location);
                Console.WriteLine("Gyldigt pas: " + (adopt.HasValidPassport ? "Ja" : "Nej"));
                Console.WriteLine("Tilgængelig: " + (adopt.IsAvailable ? "Ja" : "Nej"));
                Console.WriteLine("Billede: " + adopt.ImageUrl);
                Console.WriteLine("----------------------------------------\n");
            }
            
            // bookinger
            IBookRepository bookRepository = new BookRepository();
            List<Book> bookings = bookRepository.GetAll();

            Console.WriteLine("--- Bookinger ---\n");

            foreach (Book book in bookings)
            {
                Console.WriteLine("Booking ID: " + book.Id);
                Console.WriteLine("Kunde: " + book.CustomerName);
                Console.WriteLine("Tidspunkt: " + book.DatoTid.ToString("g"));
                Console.WriteLine("------------------------------------------\n");
            }

            // Aktiviteter
            IEventRepository eventRepository = new EventRepository();
            List<Event> events = eventRepository.GetAll();

            Console.WriteLine("--- Kommende aktiviteter hos Dyreværnet ---\n");

            foreach (Event e in events)
            {
                Console.WriteLine("Titel: " + e.Title);
                Console.WriteLine("Beskrivelse: " + e.Description);
                Console.WriteLine("Dato: " + e.Date.ToShortDateString());
                Console.WriteLine("------------------------------------------\n");
            }
            // events tilmelding---
            ISignUpRepository signUpRepository = new SignUpRepository();
            List<SignUp> signUps = signUpRepository.GetAll();

            Console.WriteLine("--- Tilmeldinger til events ---\n");

            foreach (SignUp signUp in signUps)
            {
                Console.WriteLine("Navn: " + signUp.FullName);
                Console.WriteLine("Tilmeldt Event ID: " + signUp.EventId);
                Console.WriteLine("------------------------------------------\n");
            }

            Console.WriteLine("Tryk på en tast for at afslutte.");
            Console.ReadKey();
        }
    }
}

