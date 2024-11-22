using System.Diagnostics.Tracing;

namespace FunctionalProgramming.EventSystem
{
    public class LiveEvent
    {
        public static int EventCount = 0;

        public int ID { get; }
        public string Name { get; set; }
        public DateTime DateTime { get; set; }
        public string Venue { get; set; }
        public int TicketAvailability { get; set; }

        public LiveEvent(string name, DateTime dateTime, string venue, int ticketAvailability)
        {
            Name = name;
            DateTime = dateTime;
            Venue = venue;
            TicketAvailability = ticketAvailability;
            ID = EventCount++;
        }
    }
}
