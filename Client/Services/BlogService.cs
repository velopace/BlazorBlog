using System;
using BlazorBlog.Shared;

namespace BlazorBlog.Client.Services
{
	public class BlogService : IBlogService
	{
        public List<BlogPost> Posts { get; set; } = new List<BlogPost>()
        {
            new BlogPost { Url = "new-tutorial", Title = "A New Tutorial about Blazor", Description = "This is a new tutorial, showing you how to build a blog with Blazor" },
            new BlogPost { Url = "first-post", Title = "My First Blog Post", Description = "Hi! This is my new shiny blog. Enjoy!" }
        };

        public List<BlogPost> GetBlogPosts()
        {
            return Posts;
        }

        public Task<BlogPost> GetBlogPostByUrl(string url)
        {
            throw new NotImplementedException();
        }

        public Task<BlogPost> CreateNewBlogPost(BlogPost request)
        {
            throw new NotImplementedException();
        }

    }
}

