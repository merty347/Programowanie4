using lab4.Models;
using System;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BlogContext()) 
            {

                var videoPost = new VideoPost
                {
                    Blog = new Blog
                    {
                        Name = "Blog1",
                        Author = new Author
                        {
                            Name = "Jan Kowalski"
                        }
                    },
                    Title = "test",
                    VideoUrl = "http://fake/adres"
                };

                context.Add(videoPost);

                var podcastPost = new PodcastPost
                {
                    Blog = new Blog
                    {
                        Name = "Blog2",
                        Author = new Author
                        {
                            Name = "Jan Kowalski"
                        }
                    },
                    Title = "test",
                    PodcastUrl = "http://fake/adres"
                };

                context.Add(podcastPost);

                var textPost = new TextPost
                {
                    Blog = new Blog
                    {
                        Name = "Blog3",
                        Author = new Author
                        {
                            Name = "Jan Kowalski"
                        }
                    },
                    Title = "test",
                    PostContent = "test"
                };

                context.Add(textPost);

                context.SaveChanges();
            }
        }
    }
}
