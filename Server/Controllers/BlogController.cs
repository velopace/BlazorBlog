using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorBlog.Shared;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlazorBlog.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlogController : Controller
    {
        public List<BlogPost> Posts { get; set; } = new List<BlogPost>()
        {
            new BlogPost { Url = "new-tutorial", Title = "A New Tutorial about Blazor", Description = "This is a new tutorial, showing you how to build a blog with Blazor", Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum." },
            new BlogPost { Url = "first-post", Title = "My First Blog Post", Description = "Hi! This is my new shiny blog. Enjoy!", Content = "This is my beautiful short blog post. Isn't it nice? :)" }
        };

        [HttpGet]
        public ActionResult<List<BlogPost>> GimmeAllTheBlogPosts()
        {
            return Ok(Posts);
        }

        [HttpGet("{url}")]
        public ActionResult<BlogPost> GimmeThatSingleBlogPost(string url)
        {
            var post = Posts.FirstOrDefault(p => p.Url.ToLower().Equals(url.ToLower()));

            if (post == null)
            {
                return NotFound("This post does not exist");
            }

            return Ok(post);
        }
    }
}

