﻿using AutoMapper;
using BloggingPlatform.Dal.Context;
using BloggingPlatform.Dal.Services.Interface;
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

        public List<Models.Post> GetAll()
        {
            var listPosts = _context.Posts.ToList();

            return _mapper.Map<List<Models.Post>>(listPosts);
        }

        public Models.Post Insert(Models.Post post)
        {
            var postEntity = _mapper.Map<Database.Post>(post);

            _context.Posts.Add(postEntity);
            _context.SaveChanges();

            return _mapper.Map<Models.Post>(postEntity);
        }
    }
}