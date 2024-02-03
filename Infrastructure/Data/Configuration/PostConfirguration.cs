using Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.Infrastructure.Data.Configuration
{
	public class PostConfirguration : IEntityTypeConfiguration<Post>
	{
		private Post[] initialPosts = new Post[] 
		{
			new Post(){Id = 1, Title = "My first post's title", Content = "My first post's content"},
			new Post(){Id = 2, Title = "My second post's title", Content = "My second post's content"},
			new Post(){Id = 3, Title = "My third post's title", Content = "My third post's content"}
		};

		public void Configure(EntityTypeBuilder<Post> builder)
		{
			builder.HasData(initialPosts);
		}
	}
}
