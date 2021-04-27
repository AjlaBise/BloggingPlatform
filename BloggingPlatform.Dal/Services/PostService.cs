using AutoMapper;
using BloggingPlatform.Dal.Database;
using BloggingPlatform.Dal.Helper;
using BloggingPlatform.Dal.Models;
using BloggingPlatform.Dal.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BloggingPlatform.Dal.Services
{
    public class PostService : IPostService
    {
        private readonly BloggingPlatformDbContext _context;
        private readonly Tag _tag;
        private readonly IMapper _mapper;

        public PostService(BloggingPlatformDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public bool Delete(string slug)
        {
            var entityPost = _context.Posts.Where(x => x.Slug == slug).FirstOrDefault();

            if (entityPost != null)
            {
                _context.Remove(entityPost);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Models.Post> GetAll()
        {
            var listPosts = _context.Posts.OrderByDescending(x => x.CreatedAt).ToList();

            return _mapper.Map<List<Models.Post>>(listPosts);
        }

        public Models.Post GetBySlug(string slug)
        {
            var postEntity = _context.Posts.Where(p => p.Slug == slug).FirstOrDefault();

            return _mapper.Map<Models.Post>(postEntity);
        }

        public Models.CreatePostModel Insert(Models.CreatePostModel post)
        {
            var postEntity = _mapper.Map<Database.Post>(post);

            _context.Posts.Add(postEntity);
            _context.SaveChanges();

            return _mapper.Map<Models.CreatePostModel>(postEntity);
        }

        public Models.Post Update(string slug, Models.Post post)
        {
            
            var postEntity = _context.Posts.Where(x => x.Slug == slug).FirstOrDefault();

            postEntity.Slug = post.Title.ToLower().Replace(" ", "-");
            postEntity.Title = post.Title;
            postEntity.Description = post.Description;
            postEntity.Body = post.Body;
            postEntity.Tag = post.Tag;
            postEntity.CreatedAt = post.CreatedAt;
            postEntity.UpdatedAt = post.UpdatedAt;

            _context.Posts.Attach(postEntity);
            _context.Posts.Update(postEntity);

            _context.SaveChanges();

            return _mapper.Map<Models.Post>(postEntity);
        }
    }
}