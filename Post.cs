using System;
using System.Collections.Generic;
using System.Text;

namespace lab4.Models
{
    public enum PostType 
    {
        Video,
        Audio,
        Text
    }


    public class Post
    {
        public int ID { get; set; }
        public DateTime CreatedOn { get; set; }
        public int BlogId { get; set; }
        public PostType PostType { get; set; }
        public string Title { get; set; }
        public Blog Blog { get; set; }

    }

    public class VideoPost : Post
    {
        public string VideoUrl { get; set; }
    }



    public class PodcastPost : Post
    {
        public string PodcastUrl { get; set; }
    }



    public class TextPost : Post
    {
        public string PostContent { get; set; }
    }
}
