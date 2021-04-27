using BloggingPlatform.Dal.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace BloggingPlatform.Dal.Services.Interface
{
    public interface ITagService
    {
        List<Tag> GetAllTag();
    }
}
