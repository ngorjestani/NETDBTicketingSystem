using System;
using System.Collections.Generic;

namespace TicketingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1) Submit a ticket\n2) See current tickets\n\nEnter any other key to exit.");
                string userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    Console.WriteLine("Enter ticket summary: ");
                    string summary = Console.ReadLine();
                    Ticket newTicket = new Ticket(summary);
                    AddTicketPriority(newTicket);
                    AddTicketSubmitter(newTicket);
                    AddTicketAssigned(newTicket);
                    AddTicketWatching(newTicket);
                    
                    Console.WriteLine(newTicket.ToString());
                }
                else if (userInput == "2")
                {
                    
                }
                else
                {
                    break;
                }
            }
        }

        public static void AddTicketPriority(Ticket newTicket)
        {
            string response;
            do
            {
                Console.WriteLine("Enter priority level: \n1)Low\n2)Medium\n3)High");
                response = Console.ReadLine();
            } while (response != "1" && response != "2" && response != "3");

            switch (response)
            {
                case "1":
                    newTicket.TicketPriority = Priority.Low;
                    break;
                case "2":
                    newTicket.TicketPriority = Priority.Medium;
                    break;
                case "3":
                    newTicket.TicketPriority = Priority.High;
                    break;
            }
        }

        public static void AddTicketSubmitter(Ticket newTicket)
        {
            Console.WriteLine("Who is submitting this ticket?");
            string response = Console.ReadLine();
            newTicket.TicketSubmitter = response;
        }

        public static void AddTicketAssigned(Ticket newTicket)
        {
            Console.WriteLine("Who is this ticket assigned to?");
            string response = Console.ReadLine();
            newTicket.TicketAssigned = response;
        }

        public static void AddTicketWatching(Ticket newTicket)
        {
            List<string> watchers = new List<string>();
            Console.WriteLine("How many people are watching this file?");
            int watching = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < watching; i++)
            {
                Console.WriteLine($"Enter Person {i + 1} watching: ");
                string person = Console.ReadLine();
                watchers.Add(person);
            }
        }
    }
}