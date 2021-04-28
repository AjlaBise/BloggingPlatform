using System;
using System.Collections.Generic;
using BloggingPlatform.Dal.Models;
using BloggingPlatform.Dal.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace BloggingPlatform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostService _post;

        public PostController(IPostService post)
        {
            _post = post;
        }

        [HttpGet]
        public List<Dal.Models.Post> GetAll()
        {
            return _post.GetAll();
        }

        [HttpGet("{slug}")]
        public Dal.Models.Post GetBySlug(string slug)
        {
            return _post.GetBySlug(slug);
        }

        [HttpPost]
        public Dal.Models.CreatePostModel Insert([FromBody] Dal.Models.CreatePostModel post)
        {

                return _post.Insert(post);
        }

        [HttpPut("{slug}")]
        public Dal.Models.Post Update(string slug, Dal.Models.Post post)
        {
            return _post.Update(slug, post);
        }

        [HttpDelete("{slug}")]
        public bool Delete (string slug)
        {
            return _post.Delete(slug);
        }
    }
}