using System.Collections.Generic;

namespace RssProject.Application.Dtos
{
    public class NewsFeedDto
    {
        public string Title { get; set; }
        public int AuthorsToday { get; set; }
        public string Desc { get; set; }
        public string ImgUrl { get; set; }
        public IEnumerable<EntryDto> Entries { get; set; }
    }
}
