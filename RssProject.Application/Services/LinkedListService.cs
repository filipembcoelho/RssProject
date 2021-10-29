using RssProject.Application.Clients;
using RssProject.Application.Contracts;
using Generics = global::System.Collections.Generic;

namespace RssProject.Application.Services
{
    public class LinkedListService : ILinkedListService
    {
        public Generics.IEnumerable<int> GetElements()
        {
            var list = new LinkedList<int>();

            list.Offer(1);
            list.Offer(2);
            list.Offer(3);
            list.Offer(4);
            list.Offer(5);
            list.Offer(6);

            list.Offer(2, 7);

            list.RemoveLast();

            list.RemoveFirst();

            list.OfferLast(8);

            list.OfferFirst(10);

            list.OfferFirst(9);

            list.OfferFirst(11);

            return list.ToList();
        }
    }
}
