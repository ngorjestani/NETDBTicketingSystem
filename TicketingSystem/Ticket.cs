using System;
using System.Collections.Generic;
using System.IO;

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
            TicketStatus = Status.Open;
            TicketID = nextID;
            nextID++;
        }

        public void AddToFile(string file)
        {
            StreamWriter sw = new StreamWriter(file, true);
            sw.WriteLine(ToString());
            sw.Close();
        }

        public string WatchingList(List<string> watching)
        {
          return string.Join("|", watching);
        }

        public override string ToString()
        {
            string watching = WatchingList(TicketWatching);
            return $"{TicketID},{TicketSummary},{TicketStatus},{TicketPriority},{TicketSubmitter},{TicketAssigned},{watching}";
        }
    }
}