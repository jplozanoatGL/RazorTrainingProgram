using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

public class CreateModel : PageModel
{
    [BindProperty]
    [Required]
    public string HeroName { get; set; }

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