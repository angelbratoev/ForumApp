using System.ComponentModel.DataAnnotations;
using static Infrastructure.Constants.ValidationConstants;

namespace ForumApp.Core.Models
{
	/// <summary>
	/// Post data transfer model
	/// </summary>
	public class PostModel
	{
		/// <summary>
		/// Post identificator
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Post title
		/// </summary>
		[Required(ErrorMessage = RequiredErrorMessage)]
		[StringLength(PostTitleMaxLength,
			MinimumLength = PostTitleMinLength,
			ErrorMessage =FieldLengthErrorMessage)]
		public string Title { get; set; } = string.Empty;

		/// <summary>
		/// Post content
		/// </summary>
		[Required(ErrorMessage = RequiredErrorMessage)]
		[StringLength(PostContentMaxLength,
			MinimumLength = PostContentMinLength,
			ErrorMessage = FieldLengthErrorMessage)]
		public string Content { get; set; } = string.Empty;
	}
}
