using System.Collections.Generic;

namespace RssProject.Application.Contracts
{
    public interface ILinkedListService
    {
        public IEnumerable<int> GetElements();
    }
}
