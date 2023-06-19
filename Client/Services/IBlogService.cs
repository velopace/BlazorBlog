using System;
using BlazorBlog.Shared;

namespace BlazorBlog.Client.Services
{
	public interface IBlogService
	{
        List<BlogPost> GetBlogPosts();

        BlogPost GetBlogPostByUrl(string url);

        BlogPost CreateNewBlogPost(BlogPost request);
    }
}

