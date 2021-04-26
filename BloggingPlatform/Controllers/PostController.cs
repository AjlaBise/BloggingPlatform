using System;
using System.Collections.Generic;
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

        [HttpPost]
        public Dal.Models.Post Insert([FromBody] Dal.Models.Post post)
        {
            try
            {
                return _post.Insert(post);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        [HttpPut("{id}")]
        public Dal.Models.Post Update(int id, Dal.Models.Post post)
        {
            try
            {
                return _post.Update(id, post);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        [HttpDelete("{id}")]
        public bool Delete (int id)
        {
            return _post.Delete(id);
        }
    }
}