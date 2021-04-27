using System.Collections.Generic;

namespace BloggingPlatform.Dal.Services.Interface
{
    public interface IPostService
    {
        Models.CreatePostModel Insert(Models.CreatePostModel post);

        List<Models.Post> GetAll();

        Models.Post Update(string slug, Models.Post post);

        bool Delete(string slug);
    }
}