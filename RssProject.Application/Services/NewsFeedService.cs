using AutoMapper;
using RssProject.Application.Contracts;
using RssProject.Application.Dtos;
using System.ServiceModel.Syndication;
using System.Threading.Tasks;
using System.Xml;

namespace RssProject.Application.Services
{
    public class NewsFeedService : INewsFeedService
    {
        private readonly IMapper _mapper;

        public NewsFeedService(IMapper mapper)
        {
            this._mapper = mapper;
        }

        public async Task<NewsFeedDto> GetRssNewsFeed(string url)
        {
            var feed = await GetFeed(url);
            var newsFeed = _mapper.Map<NewsFeedDto>(feed);
            return newsFeed;
        }

        private static async Task<SyndicationFeed> GetFeed(string url = null)
        {
            url ??= "https://feeds.services.tv2.dk/api/feeds/nyheder/rss";
            using var reader = XmlReader.Create(url);
            var feed = await Task.Run(() => SyndicationFeed.Load(reader));
            return feed;
        }
    }
}
