using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class Book
{
    // TODO: Define three fields: Title, Synopsis, and Price
    public string? Title { get; set; }
    public string? Synopsis { get; set; }
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
            Title = "Example Title",     
            Synopsis = "Sample Synopsis",
            Price = 19.99m
        };
    }

    public IActionResult OnPost() 
    {
        if (!ModelState.IsValid) 
        {
            return Page();
        }

        // Data is automatically retained through the bound Book property.
        return Page();
    }
}