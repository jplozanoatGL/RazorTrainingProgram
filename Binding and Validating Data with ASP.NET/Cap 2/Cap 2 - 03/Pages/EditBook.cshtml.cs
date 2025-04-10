using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class Book 
{
    public string? Title { get; set; }
    public string? Author { get; set; }
    public decimal? Price { get; set; }
}

public class EditBookModel : PageModel 
{
    [BindProperty]
    public Book BookData { get; set; } = new Book();

    public void OnGet(int id) 
    {
        BookData = new Book 
        {
            Title = "Example Book Title",      
            Author = "Sample Author",
            Price = 19.99m
        };
    }

    public IActionResult OnPost() 
    {
        if (!ModelState.IsValid) 
        {
            return Page();
        }

        return Page();
    }
}