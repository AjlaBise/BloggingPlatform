using AutoMapper;
using BloggingPlatform.Dal.Context;
using BloggingPlatform.Dal.Services.Interface;

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

        public Models.Post Insert(Models.Post post)
        {
            var postEntity = _mapper.Map<Database.Post>(post);

            _context.Posts.Add(postEntity);
            _context.SaveChanges();

            return _mapper.Map<Models.Post>(postEntity);
        }
    }
}