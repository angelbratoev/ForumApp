namespace Infrastructure.Constants
{
	/// <summary>
	/// Validation Constants
	/// </summary>
	public class ValidationConstants
	{
		/// <summary>
		/// Maximal length for Post Title
		/// </summary>
		public const int PostTitleMaxLength = 50;

		/// <summary>
		/// Minimal length for Post Title
		/// </summary>
		public const int PostTitleMinLength = 10;

		/// <summary>
		/// Maximal length for Post Content
		/// </summary>
		public const int PostContentMaxLength = 1500;

		/// <summary>
		/// Minimal length for Post Content
		/// </summary>
		public const int PostContentMinLength = 30;

		/// <summary>
		/// Required field error message
		/// </summary>
		public const string RequiredErrorMessage = "The {0} field is required!";

		public const string FieldLengthErrorMessage = "The {0} field should be between {2} and {1} characters long";
	}
}
