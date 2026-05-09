using System;
using System.Collections.Generic;
using System.Text;

namespace Inkstack.Core.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string ShortDescription { get; set; } = string.Empty;
    }
}


/*
 * 
 * 
 * public class Post
    {
	    public virtual string Description
	    { get; set; }

	    public virtual string Meta
	    { get; set; }

	    public virtual string UrlSlug
        { get; set; }

	    public virtual bool Published
	    { get; set; }

	    public virtual DateTime PostedOn
	    { get; set; }

	    public virtual DateTime? Modified
	    { get; set; }

	    public virtual Category Category
	    { get; set; }

	    public virtual IList<Tag> Tags
	    { get; set; }
    }
 * 
 * 
 * 
 * 
 * 
 */