using System.Collections.Generic;

namespace BloggingPlatform.Dal.Services.Interface
{
    public interface IPostService
    {
        Models.Post Insert(Models.Post post);

        List<Models.Post> GetAll();

        Models.Post Update(int id, Models.Post post);

        bool Delete(int id);
    }
}