using RssProject.Application.Clients;
using System;

namespace RessProject.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList<int>();

            Console.WriteLine($"Offer 1, 2, 3, 4, 5, 6");
            list.Offer(1);
            list.Offer(2);
            list.Offer(3);
            list.Offer(4);
            list.Offer(5);
            list.Offer(6);

            Console.WriteLine(list);

            Console.WriteLine("Offer 7 value on index: 2");
            list.Offer(2, 7);
            Console.WriteLine(list);

            Console.WriteLine("Remove Last");
            list.RemoveLast();
            Console.WriteLine(list);

            Console.WriteLine("Remove First");
            list.RemoveFirst();
            Console.WriteLine(list);

            Console.WriteLine("Offer Last 8 value");
            list.OfferLast(8);
            Console.WriteLine(list);

            Console.WriteLine("Offer First 10 value");
            list.OfferFirst(10);
            Console.WriteLine(list);

            Console.WriteLine("Offer First 9 value");
            list.OfferFirst(9);
            Console.WriteLine(list);

            Console.WriteLine("Offer First 11 value");
            list.OfferFirst(11);
            Console.WriteLine(list);
        }
    }
}
