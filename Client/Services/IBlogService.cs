using System;
using BlazorBlog.Shared;

namespace BlazorBlog.Client.Services
{
	public interface IBlogService
	{
        Task<List<BlogPost>> GetBlogPosts();

        Task<BlogPost> GetBlogPostByUrl(string url);

        Task<BlogPost> CreateNewBlogPost(BlogPost request);
    }
}

