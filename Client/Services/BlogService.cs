using System;
using System.Net.Http.Json;
using BlazorBlog.Shared;

namespace BlazorBlog.Client.Services
{
	public class BlogService : IBlogService
	{
        private readonly HttpClient _http;

        public BlogService(HttpClient http)
        {
            _http = http;            
        }

        public async Task<List<BlogPost>> GetBlogPosts()
        {
            return await _http.GetFromJsonAsync<List<BlogPost>>("api/Blog");
        }

        public async Task<BlogPost> GetBlogPostByUrl(string url)
        {
            var post = await _http.GetFromJsonAsync<BlogPost>($"api/Blog/{url}");
            return post;
        }

        public BlogPost CreateNewBlogPost(BlogPost request)
        {
            throw new NotImplementedException();
        }

    }
}

