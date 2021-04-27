using AutoMapper;
using BloggingPlatform.Dal.Database;
using BloggingPlatform.Dal.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BloggingPlatform.Dal.Services
{
    public class PostService : IPostService
    {
        private readonly BloggingPlatformDbContext _context;
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
            try
            {
                var postEntity = new Post
                {
                    Slug = CreateSlugWithEnglishChar_CreatePost(post),
                    Title = post.Title,
                    Description = post.Description,
                    Body = post.Body,
                    Tag = post.Tag,
                    CreatedAt = post.CreatedAt,
                    UpdatedAt = post.UpdatedAt
                };

                _context.Posts.Add(postEntity);
                _context.SaveChanges();

                return _mapper.Map<Models.CreatePostModel>(postEntity);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Models.Post Update(string slug, Models.Post post)
        {
            try
            {
                var postEntity = _context.Posts.Where(x => x.Slug == slug).FirstOrDefault();

                postEntity.Slug = CreateSlugWithEnglishChar(post);
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
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private string CreateSlugWithEnglishChar(Models.Post post)
        {
            var slug = post.Title
                            .ToLower().Replace(" ", "-")
                            .Replace("?", "").Replace(".", "").Replace("!", "");

            byte[] tempBytes;
            tempBytes = System.Text.Encoding.GetEncoding("ISO-8859-8").GetBytes(slug);

            return System.Text.Encoding.UTF8.GetString(tempBytes);
        }

        private string CreateSlugWithEnglishChar_CreatePost(Models.CreatePostModel post)
        {
            var slug = post.Title
                            .ToLower().Replace(" ", "-")
                            .Replace("?", "").Replace(".", "").Replace("!", "");

            byte[] tempBytes;
            tempBytes = System.Text.Encoding.GetEncoding("ISO-8859-8").GetBytes(slug);

            return System.Text.Encoding.UTF8.GetString(tempBytes);
        }
    }
}