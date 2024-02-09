using ForumApp.Core.Contracts;
using ForumApp.Core.Models;
using Infrastructure.Data;
using Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.Core.Services
{
	public class PostService : IPostService
	{
		private readonly ForumAppDbContext context;

        public PostService(ForumAppDbContext _context)
        {
            context = _context;
        }

		public async Task<IEnumerable<PostModel>> GetAllPostsAsync()
		{
			return await context.Posts
				.Select(p => new PostModel() 
				{ 
					Id = p.Id,
					Title =  p.Title,
					Content = p.Content
				})
				.AsNoTracking()
				.ToListAsync();
		}

		public async Task AddAsync(PostModel model)
		{
            var post = new Post()
            {
                Title = model.Title,
                Content = model.Content
            };

			await context.Posts.AddAsync(post);
			await context.SaveChangesAsync();
        }

        public async Task<PostModel> GetByIdAsync(int id)
        {
            var entity = await context.FindAsync<Post>(id);

			PostModel model = new()
			{
				Id = entity.Id,
				Title = entity.Title,
				Content = entity.Content
			};

			return model;
        }

        public async Task UpdatePostAsync(int id, PostModel model)
        {
			Post post = await context.FindAsync<Post>(id);

			post.Title = model.Title;
			post.Content = model.Content;

			await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            Post entity = await context.FindAsync<Post>(id);

			context.Posts.Remove(entity);
			await context.SaveChangesAsync();
        }
    }
}
