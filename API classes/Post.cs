using System.Collections.Generic;

namespace Tumblr.API
{
    public class Post
    {
        public string type { get; set; }
        public string blog_name { get; set; }
        public Blog2 blog { get; set; }
        public object id { get; set; }
        public string post_url { get; set; }
        public string slug { get; set; }
        public string date { get; set; }
        public int timestamp { get; set; }
        public string state { get; set; }
        public string format { get; set; }
        public string reblog_key { get; set; }
        public List<object> tags { get; set; }
        public string short_url { get; set; }
        public string summary { get; set; }
        public bool should_open_in_legacy { get; set; }
        public object recommended_source { get; set; }
        public object recommended_color { get; set; }
        public int note_count { get; set; }
        public string caption { get; set; }
        public Reblog reblog { get; set; }
        public List<object> trail { get; set; }
        public string image_permalink { get; set; }
        public List<Photo> photos { get; set; }
        public bool can_like { get; set; }
        public bool can_reblog { get; set; }
        public bool can_send_in_message { get; set; }
        public bool can_reply { get; set; }
        public bool display_avatar { get; set; }
        public string photoset_layout { get; set; }
        public string source_url { get; set; }
        public string source_title { get; set; }
    }
}
