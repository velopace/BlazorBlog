using System;
using BlazorBlog.Shared;

namespace BlazorBlog.Client.Services
{
	public interface IBlogService
	{
        List<BlogPost> GetBlogPosts();

        Task<BlogPost> GetBlogPostByUrl(string url);

        Task<BlogPost> CreateNewBlogPost(BlogPost request);
    }
}

