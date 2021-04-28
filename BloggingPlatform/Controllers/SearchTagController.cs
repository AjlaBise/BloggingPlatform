using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BloggingPlatform.Dal.Models;
using BloggingPlatform.Dal.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BloggingPlatform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchTagController : ControllerBase
    {
        private readonly IPostService _post;

        public SearchTagController(IPostService post)
        {
            _post = post;
        }

        [HttpGet]
        public List<Dal.Models.Post> Get([FromQuery] PostSearchRequest request)
        {
            return _post.Get(request);
        }

    }
}
