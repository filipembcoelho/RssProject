using Microsoft.AspNetCore.Mvc;
using RssProject.Application.Contracts;
using RssProject.Application.Dtos;
using System.Threading.Tasks;

namespace RssProject.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        private readonly INewsFeedService _newsFeedService;

        public TestController(INewsFeedService newsFeedService)
        {
            _newsFeedService = newsFeedService;
        }

        [HttpGet("getRssNewsOne")]
        public async Task<ActionResult<NewsFeedDto>> GetRssNewsOne()
        {
            string url = "https://feeds.services.tv2.dk/api/feeds/nyheder/rss";
            return await _newsFeedService.GetRssNewsFeed(url);
        }

        [HttpGet("getRssNewsTwo")]
        public async Task<ActionResult<NewsFeedDto>> GetRssNewsTwo()
        {
            string url = "https://rss.art19.com/apology-line";
            return await _newsFeedService.GetRssNewsFeed(url);
        }

        [HttpGet("getRssNewsThree")]
        public async Task<ActionResult<NewsFeedDto>> GetRssNewsThree()
        {
            string url = "https://feeds.simplecast.com/54nAGcIl";
            return await _newsFeedService.GetRssNewsFeed(url);
        }

        [HttpGet("getRssNewsFour")]
        public async Task<ActionResult<NewsFeedDto>> GetRssNewsFour()
        {
            string url = "http://rss.cnn.com/rss/cnn_topstories.rss";
            return await _newsFeedService.GetRssNewsFeed(url);
        }
    }
}