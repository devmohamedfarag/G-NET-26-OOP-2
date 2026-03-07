namespace AssignmetOOP02
{
    public class Ticket
    {
        private static int ticketCounter = 0;
        public int TicketId { get;}

        private string movieName;
        private double price;
        public string MovieName
        {
            get => movieName; 
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Movie name cannot be empty.");
                }
                movieName = value;
            }
        }
        public TicketType Type { get; set; }
        public SeatLoctaion Seat { get; set; }
        public double Price
        {
            get => price; 
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price cannot be negative.");
                }
                price = value;
            }
        }
        public double PriceAfterTax => Price * 1.14;

        public Ticket(string movieName, TicketType type, SeatLoctaion seat, double price)
        {
            ticketCounter++;
            TicketId = ticketCounter;

            MovieName = movieName;
            Type = type;
            Seat = seat;
            Price = price;
        }

        public static int GetTotalTicketsSold() => ticketCounter;
        
        public override string ToString() => $"Ticket ID: {TicketId}, Movie: {MovieName}, Type: {Type}, Seat: {Seat}, Price: {Price:C}, Price After Tax: {PriceAfterTax:C}";
        
    }
}
