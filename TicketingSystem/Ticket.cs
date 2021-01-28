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

        public string WatchingList(List<string> watching)
        {
          return string.Join("|", watching);
        }

        public override string ToString()
        {
          return $"{TicketID},{TicketSummary},{TicketStatus},{TicketPriority},{TicketSubmitter},{TicketAssigned},{WatchingList(TicketWatching)}";
        }
    }
}