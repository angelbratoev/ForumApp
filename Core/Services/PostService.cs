using ForumApp.Core.Contracts;
using ForumApp.Core.Models;
using Infrastructure.Data;
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
	}
}
