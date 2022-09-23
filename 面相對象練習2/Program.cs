using System;

namespace 面相對象練習2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ticket t = new Ticket(90);
            t.ShowTicket();
            Console.ReadKey();
        }
    }
}
