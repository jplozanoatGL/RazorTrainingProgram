using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class Product 
{
    public string? ProductName { get; set; }
    public string? Description { get; set; }
    public decimal? Price { get; set; }
}

public class EditModel : PageModel 
{
    [BindProperty]
    public Product Product { get; set; } = new Product();

    public void OnGet(int id) 
    {
        // Simulate data retrieval
        Product = new Product 
        {
            ProductName = "Sample Product",      // Example data retrieval
            Description = "Product Description",
            Price = 20.50m
        };
    }

    public IActionResult OnPost() 
    {
        Console.WriteLine(Product.ProductName);
        if (!ModelState.IsValid) 
        {
            return Page();
        }

        // Data is automatically retained through the bound Product property.
        return Page();
    }
}