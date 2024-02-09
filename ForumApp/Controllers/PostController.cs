using ForumApp.Core.Contracts;
using ForumApp.Core.Models;
using ForumApp.Core.Services;
using Infrastructure.Data.Models;
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
		public IActionResult Add()
		{
			PostModel model = new();

			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> Add(PostModel model)
		{
			if(ModelState.IsValid == false)
			{
				return View(model);
			}

			await postService.AddAsync(model);

			return RedirectToAction(nameof(Index));
		}

		[HttpGet]
		public async Task<IActionResult> Edit(int id)
		{
			if (ModelState.IsValid == false)
			{
				return RedirectToAction(nameof(Index));
			}

            PostModel model = await postService.GetByIdAsync(id);

			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> Edit(int id, PostModel model)
		{
			if (ModelState.IsValid == false)
			{
				return View(model);
			}

			await postService.UpdatePostAsync(id, model);

			return RedirectToAction(nameof(Index));
		}

		[HttpPost]
		public async Task<IActionResult> Delete(int id)
		{
			await postService.DeleteAsync(id);

			return RedirectToAction(nameof(Index));
		}
	}
}
