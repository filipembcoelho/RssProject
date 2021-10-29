namespace RssProject.Application.Clients
{
    public class Node<TEntity>
    {
        public TEntity Data { get; set; }
        public Node<TEntity> Next { get; set; }

        public Node(TEntity data)
        {
            Data = data;
        }
    }
}
