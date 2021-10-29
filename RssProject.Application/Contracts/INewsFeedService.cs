using RssProject.Application.Dtos;
using System.Threading.Tasks;

namespace RssProject.Application.Contracts
{
    public interface INewsFeedService
    {
        Task<NewsFeedDto> GetRssNewsFeed(string url);
    }
}
