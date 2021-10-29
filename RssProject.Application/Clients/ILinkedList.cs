namespace RssProject.Application.Clients
{
    public interface ILinkedList<TEntity>
    {
        void Offer(TEntity data);
        void Offer(int index, TEntity data);
        void OfferFirst(TEntity data);
        void OfferLast(TEntity data);
        TEntity Peek(int index);
        TEntity Remove(int index);
        TEntity RemoveFirst();
        TEntity RemoveLast();
        bool IsEmpty();
        int Size();
    }
}
