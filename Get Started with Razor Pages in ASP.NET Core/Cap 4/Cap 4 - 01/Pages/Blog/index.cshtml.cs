using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

public class BlogIndexModel : PageModel
{
    public List<BlogPost> BlogPosts { get; set; }

    public void OnGet()
    {
        BlogPosts = new List<BlogPost>
        {
            new BlogPost { Id = 1, Title = "First Post", Content = "This is the first blog post.", CreatedAt = DateTime.Now },
            new BlogPost { Id = 2, Title = "Second Post", Content = "This is the second blog post.", CreatedAt = DateTime.Now }
        };
    }
}