using System;

namespace RssProject.Application.Clients
{
    internal class NoSuchElementException : Exception
    {
        public NoSuchElementException(string msg) : base(msg) { }
    }
}
