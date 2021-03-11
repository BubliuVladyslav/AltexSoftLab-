using LuckyTicket.Interfaces;
using System;

namespace LuckyTicket
{
    class StatrtUp
    {
        private readonly ITicket _ticket;

        public StatrtUp()
        {
            _ticket = new Ticket();
        }

        public void TicketVerification()
        {
            int minLength = 4;
            int maxLength = 8;
            string number;
            string choice;

            Console.WriteLine("Hello,  I will check your ticket, please enter the number!");
            Console.WriteLine("The minimum number length must be at least - " + minLength);
            Console.WriteLine("The maximum length of a number must be no more than - " +  maxLength);
            Console.WriteLine();

            for (; ; )
            {
                Console.WriteLine("Please, enter the numbers from the ticket");
                number = Console.ReadLine();

                try
                {
                    if (_ticket.LuckyTest(minLength, maxLength, number)) Console.WriteLine("Congratulations !");
                    else { Console.WriteLine("Lucky another time"); }
                }
                catch
                {
                    Console.WriteLine("Something went wrong");
                }

                Console.WriteLine("If you want to exit - press q");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "q":
                        Console.WriteLine("Your decided exit");
                        break;
                    default:
                        Console.WriteLine("Your decided you decided to continue");
                        continue;
                }
                if (choice == "q") break;
            }
        }
    }
}
