using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace CodeYad_Blog.Web.Areas.Admin.Models.Posts
{
    public class CreatePostViewModel
    {
        public int CategoryId { get; set; }
        public int? SubCategoryId { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        [UIHint("CKEditor4")]
        public string Description { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}