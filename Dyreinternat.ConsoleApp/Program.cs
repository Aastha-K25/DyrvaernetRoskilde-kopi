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
                Console.WriteLine("Welcome to Roskilde Dyreinternat!");
                Console.WriteLine("----Dyreinternat Menu----");
                Console.WriteLine("1. Se alle dyr til adoption");
                Console.WriteLine("2. Se kun tilgængelig dyr");
                Console.WriteLine("3. Se Booking");
                Console.WriteLine("4. Se Aktiviteter");
                Console.WriteLine("5. Se tilmelding til Aktiviteter");
                Console.WriteLine("9. Afslut");
                Console.WriteLine("Vælg en funktion");

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
                            List<Adopt> available = new List<Adopt>();

                            foreach (Adopt dog in all)
                            {
                                if (dog.IsAvailable) ;
                            }
                    }

                    VisAdoptionsListe()

                    case "3":
                    List<Book> booking = bookRepository.GetAll();
                    Console.WriteLine("---Bookin---/n");
                    foreach (Book book in booking)
                    {
                        Console.WriteLine("Booking ID:" + book.Id);
                        Console.WriteLine("Kunde:" + book.CustomerName);
                        Console.WriteLine("Tidspunkt:" + book.DatoTid.ToString());
                        Console.WriteLine("--------------------------------------");
                    }

                    break;
                    case "4":
                    List<Event> events = eventRepository.GetAll();
                    Console.WriteLine("---Kommende aktiviteter hos Roskilde Dyreværnet---/n");
                    foreach (Event e in events)
                    {
                        Console.WriteLine("Titel:" + e.Title);
                        Console.WriteLine("Beskrivelse:" + e.Description);
                        Console.WriteLine("Date:" + e.Date.ToShortDateString());
                        Console.WriteLine("-------------------------------------");
                    }

                    break;
                    case "5":
                    List<SignUp> signUps = signUpRepository.GetAll();
                    foreach (SignUp signUp in signUps)
                    {
                        Console.WriteLine("---Tildmeldinger til aktiviteter---\n");
                        Console.WriteLine("Navn:" + signUps.FullName);
                        Console.WriteLine("-------------------------------------\n");
                    }

                    break;
                    case "9":
                    running = false;
                    break;
                    default:
                    Console.WriteLine("Ugyldigt valg. Prøve igen");
                    break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Der opstod en fejl:" + ex.Message);
            }
            Console.WriteLine("\nTryk på en tast for at fortsætte...");
            Console.ReadLine();
        }

        private static void VisAdoptionsListe(List<Adopt> dogs)
        {
            Console.WriteLine("----Liste over dyr til adoption----");
            foreach (Adopt adopt in dogs)
            {
                Console.WriteLine("Navn:" + adopt.Name);
                Console.WriteLine("Race:" + adopt.Breed);
                Console.WriteLine("Farve:" + adopt.Color);
                Console.WriteLine("Køn:" + adopt.Gender);
                Console.WriteLine("Vægt:" + adopt.Weight + "kg");
                Console.WriteLine("Alder:" + adopt.Age + "år");
                Console.WriteLine("Steriliseret:" + (adopt.IsSterilized ? "Ja" : "Nej"));
                Console.WriteLine("Placering:" + adopt.Location);
                Console.WriteLine("Gyldigt pas" + (adopt.HasValidPassport ? "Ja" : "Nej"));
                Console.WriteLine("Tilgængelig" + (adopt.IsAvailable ? "Ja" : "Nej"));
                Console.WriteLine("Billede:" + Adopt.ImageUrl);
                Console.WriteLine("-----------------------------------\n");

            }
        }
    }
}

