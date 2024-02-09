using ForumApp.Core.Models;
using Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.Core.Contracts
{
	public interface IPostService
	{
        Task AddAsync(PostModel post);
        Task DeleteAsync(int id);
        Task<IEnumerable<PostModel>> GetAllPostsAsync();
        Task<PostModel> GetByIdAsync(int id);
        Task UpdatePostAsync(int id, PostModel model);
    }
}
