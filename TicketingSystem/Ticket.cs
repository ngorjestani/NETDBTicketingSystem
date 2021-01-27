using System.Collections.Generic;

namespace TicketingSystem
{
    public class Ticket
    {
        public int TicketID { get; set; }
        public string TicketSummary { get; set; }
        public Status TicketStatus { get; set; }
        public Priority TicketPriority { get; set; }
        public string TicketSubmitter { get; set; }
        public string TicketAssigned { get; set; }
        public List<string> TicketWatching { get; set; }

        private static int nextID = 1;

        public Ticket(string summary)
        {
            TicketSummary = summary;
            TicketID = nextID;
            nextID++;
        }
    }
}