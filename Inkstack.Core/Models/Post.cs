using System;
using System.Collections.Generic;
using System.Text;

namespace Inkstack.Core.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
		public string Slug { get; set; } = string.Empty;
		public string Excerpt { get; set; } = string.Empty;
		public string ContentMarkdown { get; set; } = string.Empty;
        public bool IsPublished { get; set; }
        public virtual string Meta { get; set; } = string.Empty;
        public DateTimeOffset CreatedAtUtc { get; set; } = DateTimeOffset.UtcNow;
        public DateTimeOffset? UpdatedAtUtc { get; set; }
        public DateTimeOffset? PublishedAtUtc { get; set; }
    }
}