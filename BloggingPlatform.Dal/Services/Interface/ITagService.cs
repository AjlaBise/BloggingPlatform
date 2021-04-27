using BloggingPlatform.Dal.Helper;
using System.Collections.Generic;

namespace BloggingPlatform.Dal.Services.Interface
{
    public interface ITagService
    {
        List<Tag> GetAllTag();
    }
}