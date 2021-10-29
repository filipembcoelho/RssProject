using System.Collections.Generic;

namespace RssProject.Application.Dtos
{
    public class EntryDto
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public string PubDate { get; set; }
        public IEnumerable<string> Authors { get; set; }
    }
}
