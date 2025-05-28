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
            IAdoptRepository adoptRepository = new AdoptRepository();
            IBookRepository bookRepository = new BookRepository();
            IEventRepository eventRepository = new EventRepository();
            ISignUpRepository signUpRepository = new SignUpRepository();

            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("---- Dyreinternat Menu ----");
                Console.WriteLine("1. Se alle dyr til adoption");
                Console.WriteLine("2. Se kun tilgængelige dyr");
                Console.WriteLine("3. Se bookinger");
                Console.WriteLine("4. Se aktiviteter");
                Console.WriteLine("5. Se event tilmeldinger");
                Console.WriteLine("9. Afslut");
                Console.Write("Vælg en funktion: ");

                try
                {
                    string valg = Console.ReadLine();

                    switch (valg)
                    {
                        case "1":
                            List<Adopt> allDogs = adoptRepository.GetAll();
                            VisAdoptionsListe(allDogs);
                            break;

                        case "2":
                            List<Adopt> all = adoptRepository.GetAll();
                            List<Adopt> availableDogs = new List<Adopt>();

                            foreach (Adopt dog in all)
                            {
                                if (dog.IsAvailable)
                                {
                                    availableDogs.Add(dog);
                                }
                            }

                            VisAdoptionsListe(availableDogs);
                            break;

                        case "3":
                            List<Book> bookings = bookRepository.GetAll();
                            Console.WriteLine("--- Bookinger ---\n");
                            foreach (Book book in bookings)
                            {
                                Console.WriteLine("Booking ID: " + book.Id);
                                Console.WriteLine("Kunde: " + book.CustomerName);
                                Console.WriteLine("Tidspunkt: " + book.DatoTid.ToString("g"));
                                Console.WriteLine("------------------------------------------\n");
                            }
                            break;

                        case "4":
                            List<Event> events = eventRepository.GetAll();
                            Console.WriteLine("--- Kommende aktiviteter hos Dyreværnet ---\n");
                            foreach (Event e in events)
                            {
                                Console.WriteLine("Titel: " + e.Title);
                                Console.WriteLine("Beskrivelse: " + e.Description);
                                Console.WriteLine("Dato: " + e.Date.ToShortDateString());
                                Console.WriteLine("------------------------------------------\n");
                            }
                            break;

                        case "5":
                            List<SignUp> signUps = signUpRepository.GetAll();
                            Console.WriteLine("--- Tilmeldinger til events ---\n");
                            foreach (SignUp signUp in signUps)
                            {
                                Console.WriteLine("Navn: " + signUp.FullName);
                                Console.WriteLine("Tilmeldt Event ID: " + signUp.EventId);
                                Console.WriteLine("------------------------------------------\n");
                            }
                            break;

                        case "9":
                            running = false;
                            break;

                        default:
                            Console.WriteLine("Ugyldigt valg. Prøv igen.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Der opstod en fejl: " + ex.Message);
                }

                Console.WriteLine("\nTryk på en tast for at fortsætte...");
                Console.ReadKey();
            }
        }

        static void VisAdoptionsListe(List<Adopt> dogs)
        {
            Console.WriteLine("---- Liste over dyr til adoption ----\n");

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
        }
    }
}

