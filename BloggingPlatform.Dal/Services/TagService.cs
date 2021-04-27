using BloggingPlatform.Dal.Helper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BloggingPlatform.Dal.Services.Interface
{
    public class TagService : ITagService
    {
        public List<string> GetAllTag()
        {
            return Enum.GetNames(typeof(Tag)).ToList();
            //List<Tag> tags = Enum.GetValues(typeof(Tag))
            //              .Cast<Tag>()
            //              .ToList();

            //return tags;
        }
    }
}
