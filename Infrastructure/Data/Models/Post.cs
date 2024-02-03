using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Data.Models
{
    [Comment("Post data model")]
    public class Post
    {
        [Comment("Post identificator")]
        [Key]
        public int Id { get; set; }

        [Comment("Post title")]
        [Required]
        [StringLength(50)]
        public string Title { get; set; } = string.Empty;

        [Comment("Post content")]
        [Required]
        [StringLength(1500)]
        public string Content { get; set; } = string.Empty;
    }
}
