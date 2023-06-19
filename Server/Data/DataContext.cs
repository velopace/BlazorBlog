using System;
using BlazorBlog.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorBlog.Server.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> option) : base(option)
		{
		}

		public DbSet<BlogPost> BlogPosts { get; set; }
	}
}

