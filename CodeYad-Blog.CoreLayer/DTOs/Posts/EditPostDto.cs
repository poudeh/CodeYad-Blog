﻿namespace CodeYad_Blog.CoreLayer.DTOs.Posts
{
    public class EditPostDto
    {
        public int PostId { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
    }
}