using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

public class AddHeroModel : PageModel
{
    [BindProperty]
    [Required]
    public string HeroName { get; set; }

    [BindProperty]
    [Required]
    public string Description { get; set; } 

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        // Handle form submission
        return RedirectToPage("Index");
    }
}