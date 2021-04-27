using BloggingPlatform.Dal.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BloggingPlatform.Dal.Services.Interface
{
    public class TagService : ITagService
    {
        public List<Tag> GetAllTag()
        {
            List<Tag> tags = Enum.GetValues(typeof(Tag))
                          .Cast<Tag>()
                          .ToList();

            return tags;
        }
    }
}
