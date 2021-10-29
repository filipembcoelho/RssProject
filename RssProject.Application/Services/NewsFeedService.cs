using RssProject.Application.Contracts;
using RssProject.Application.Dtos;
using System.Threading.Tasks;

namespace RssProject.Application.Services
{
    public class NewsFeedService : INewsFeedService
    {

        public NewsFeedService()
        {
        }


        public Task<NewsFeedDto> GetRssNewsFeed(string url)
        {
            throw new System.NotImplementedException();
        }
    }
}
