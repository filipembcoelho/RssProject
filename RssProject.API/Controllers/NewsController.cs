using Microsoft.AspNetCore.Mvc;
using RssProject.Application.Contracts;
using RssProject.Application.Dtos;
using System.Threading.Tasks;

namespace RssProject.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NewsController : ControllerBase
    {
        private readonly INewsFeedService _newsFeedService;

        public NewsController(INewsFeedService newsFeedService)
        {
            _newsFeedService = newsFeedService;
        }

        [HttpGet("getRssNews")]
        public async Task<ActionResult<NewsFeedDto>> GetRssNews([FromQuery] string url)
        {
            if (url is null)
            {
                return BadRequest("Url must be provided");
            }
            return await _newsFeedService.GetRssNewsFeed(url);
        }
    }
}
