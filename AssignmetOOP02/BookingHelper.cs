using System.Diagnostics.Metrics;

namespace AssignmetOOP02
{
    public static class BookingHelper
    {
        public static double CalcGroupDiscount(int numberOfTickets, double pricePerTicket)
        {
            double totalPrice = numberOfTickets * pricePerTicket;
           
            if (numberOfTickets >= 5)
            {
                return totalPrice * 0.9; 
            }
            return totalPrice;
        }
       
        private static int Counter = 0;
      
        public static string GenerateBookingReference()
        {
            Counter++;
            return $"BK-{Counter}";
        }
    }
}
