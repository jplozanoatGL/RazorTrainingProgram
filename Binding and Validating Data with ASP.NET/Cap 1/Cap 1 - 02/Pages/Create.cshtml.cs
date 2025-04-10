using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

public class CreateModel : PageModel
{
    [BindProperty]
    [Required]
    public string Name { get; set; }
    
    
    [BindProperty]
    [Required]
    public string Superpower { get; set; }

    // TODO: Add a string property for Superpower, make sure it is bindable and required

    public IActionResult OnPost()
    {
        Console.WriteLine($"ModelState: {ModelState.IsValid}");
        if (!ModelState.IsValid)
        {
            return Page();
        }

        // Handle form submission
        return RedirectToPage("Index");
    }
}