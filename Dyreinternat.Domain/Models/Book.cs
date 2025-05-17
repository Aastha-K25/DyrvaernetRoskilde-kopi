namespace Dyreinternat.Domain.Models
{

    public class Book
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public DateTime DatoTid { get; set; }

        public Book()
        {

        }

        public Book(int id, string KundeNavn, DateTime datoTid)
        {
            Id = id;
            CustomerName = KundeNavn;
            DatoTid = datoTid;
        }

        public override string ToString()
        {
            return "Booking ID: " + Id + ", Navn: " + CustomerName + ", Tidspunkt: " + DatoTid.ToString("g");

        }
    }
}