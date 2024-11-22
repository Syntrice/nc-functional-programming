namespace FunctionalProgramming.EventSystem
{
    public class EventManager
    {
        public static List<LiveEvent> LiveEvents { get; private set; } = new List<LiveEvent>();

        public static void AddEvent(string name, string date, string venue, int ticketAvailability)
        {
            DateTime dateTime = DateTime.Parse(date);
            LiveEvent liveEvent = new LiveEvent(name, dateTime, venue, ticketAvailability);
            LiveEvents.Add(liveEvent);
        }

        // public static void UpdateAvailability

        public static string GetEventInformationById(int id)
        {
            LiveEvent liveEvent = LiveEvents.Find(e => e.ID == id);
            return $"{liveEvent.Name} {liveEvent.ID} {liveEvent.DateTime.ToString("dd/MM/yy")} {liveEvent.Venue}"
        }
        
    }
}
