using ForumApp.Infrastructure.Data.Configuration;
using Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
	public class ForumAppDbContext : DbContext
	{
        public ForumAppDbContext(DbContextOptions<ForumAppDbContext> options)
            : base(options)
        {
            
        }

		public DbSet<Post> Posts { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration<Post>(new PostConfirguration());
			base.OnModelCreating(modelBuilder);
		}
	}
}
