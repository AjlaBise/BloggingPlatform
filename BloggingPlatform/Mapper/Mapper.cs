using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace BloggingPlatform.Dal.Mapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Database.Post, Models.Post>().ReverseMap();
            CreateMap<Database.Post, Models.CreatePostModel>().ReverseMap();
            CreateMap<Database.Post, Models.PostSearchRequest>().ReverseMap();
        }
    }
}