using System.Text;
using Generics = global::System.Collections.Generic;

namespace RssProject.Application.Clients
{
    public class LinkedList<TEntity> : ILinkedList<TEntity>
    {
        private static int _counter;
        private Node<TEntity> _head;
        private Node<TEntity> _tail;

        public LinkedList()
        {
            _head = _tail = null;
        }

        public void Offer(TEntity data)
        {
            if (IsEmpty())
            {
                _head = _tail = new Node<TEntity>(data);
            }
            else
            {
                var newNode = new Node<TEntity>(data);
                _tail.Next = newNode;
                _tail = newNode;
            }
            _counter++;
        }

        public void Offer(int index, TEntity data)
        {
            var newNode = new Node<TEntity>(data);
            if (IsEmpty())
            {
                _head = _tail = newNode;
            }

            var current = _head;

            while (index > 1)
            {
                current = current.Next;
                index--;
            }

            newNode.Next = current.Next;
            current.Next = newNode;
            _counter++;
        }

        public void OfferFirst(TEntity data)
        {
            if (IsEmpty())
            {
                Offer(data);
            }

            var newNode = new Node<TEntity>(data)
            {
                Next = _head
            };
            _counter++;
            _head = newNode;
        }

        public void OfferLast(TEntity data)
        {
            Offer(data);
        }

        public TEntity Peek(int index)
        {
            var node = _head;

            while (index > 0)
            {
                node = node.Next;
                index--;
            }

            return node.Data;
        }

        public TEntity Remove(int index)
        {
            if (IsEmpty())
            {
                throw new NoSuchElementException("List is Empty");
            }

            Node<TEntity> previousNode = null;
            var node = _head;

            if (_head == _tail)
            {
                var data = _head.Data;
                _head = _tail = null;
                return data;
            }

            while (index > 0)
            {
                previousNode = node;
                node = node.Next;
                index--;
            }

            previousNode.Next = node.Next;
            _counter--;
            return node.Data;
        }

        public TEntity RemoveFirst()
        {
            if (IsEmpty())
            {
                throw new NoSuchElementException("List is Empty");
            }

            var removedItem = _head.Data;
            if (_head == _tail)
            {
                _head = _tail = null;
            }
            else
            {
                _head = _head.Next;
            }

            _counter--;
            return removedItem;
        }

        public TEntity RemoveLast()
        {
            if (IsEmpty())
            {
                throw new NoSuchElementException("List is Empty");
            }

            var removedItem = _tail.Data;
            if (_head == _tail)
            {
                _head = _tail = null;
            }
            else
            {
                var current = _head;
                while (current.Next != _tail)
                {
                    current = current.Next;
                }
                _tail = current;
                current.Next = null;
            }

            _counter--;
            return removedItem;
        }

        public bool IsEmpty()
        {
            return _head == null;
        }

        public int Size()
        {
            return _counter;
        }

        public Generics.IEnumerable<TEntity> ToList()
        {
            var list = new Generics.List<TEntity>();
            for (var i = 0; i < Size(); i++)
            {
                list.Add(Peek(i));
            }
            return list;
        }

        public override string ToString()
        {
            if (IsEmpty())
            {
                return "[]";
            }
            var sb = new StringBuilder();
            sb.Append('[');
            for (var i = 0; i < Size(); i++)
            {
                sb.Append(Peek(i));
                sb.Append(i == Size() - 1 ? ']' : ';');
            }
            return sb.ToString();
        }


    }
}
