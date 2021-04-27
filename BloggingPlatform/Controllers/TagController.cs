using System.Collections.Generic;
using BloggingPlatform.Dal.Helper;
using BloggingPlatform.Dal.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace BloggingPlatform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagController : ControllerBase
    {
        private readonly ITagService _tag;

        public TagController(ITagService tag)
        {
            _tag = tag;
        }

        [HttpGet]
        public List<string> GetAllTag()
        {
            return _tag.GetAllTag();
        }
    }
}