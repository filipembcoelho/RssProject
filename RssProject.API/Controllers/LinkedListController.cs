using Microsoft.AspNetCore.Mvc;
using RssProject.Application.Contracts;
using System.Collections.Generic;

namespace RssProject.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LinkedListController
    {
        private readonly ILinkedListService _listService;

        public LinkedListController(ILinkedListService listService)
        {
            _listService = listService;
        }

        [HttpGet("getElements")]
        public IEnumerable<int> GetElements()
        {
            return _listService.GetElements();
        }
    }
}
