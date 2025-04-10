using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class Book 
{
    public string? Title { get; set; }
    public string? Author { get; set; }
    public decimal? Price { get; set; }
}

public class EditModel : PageModel 
{
    [BindProperty]
    public Book BookData { get; set; } = new Book();

    public void OnGet(int id) 
    {
        // Handle GET request
        BookData = new Book 
        {
            Title = "How to sail",      
            Author = "Jc McLoving",
            Price = 100.00m
        };
    }

    public IActionResult OnPost() 
    {
        if (!ModelState.IsValid) 
        {
            return Page();
        }

        // Data is automatically retained through the bound Book property
        return Page();
    }
}