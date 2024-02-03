using ForumApp.Core.Contracts;
using ForumApp.Core.Models;
using ForumApp.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace ForumApp.Controllers
{
	public class PostController : Controller
	{
		private readonly IPostService postService;

        public PostController(IPostService _postService)
        {
			postService = _postService;
        }

		[HttpGet]
        public async Task<IActionResult> Index()
		{
			IEnumerable<PostModel> posts = await postService.GetAllPostsAsync();
			return View(posts);
		}

		[HttpGet]
		public async Task<IActionResult> Add()
		{

		}
	}
}
