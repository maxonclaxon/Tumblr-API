using System.Collections.Generic;

namespace Tumblr.API
{
    public class ResponseBlog
    {
        public Blog blog { get; set; }
        public List<Post> posts { get; set; }
        public int total_posts { get; set; }
        public Links _links { get; set; }
    }
}
