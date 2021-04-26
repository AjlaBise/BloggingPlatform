using BloggingPlatform.Dal.Helper;
using System;

namespace BloggingPlatform.Dal.Models
{
    public partial class Post
    {
        public string Slug { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Body { get; set; }

        public Tag Tag { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
