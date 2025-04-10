using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

public class AddAliasModel : PageModel
{
    // TODO: Add proper field annotations
    [BindProperty]
    [Required]
    public string Alias { get; set; }

    public IActionResult OnPost()
    {
        // TODO: Validate is the form data is valid
        if (!ModelState.IsValid)
        {
            return Page();
        }
        // Handle form submission
        // TODO: Redirect to the correct page after handling form submission
        return RedirectToPage("Index");
    }
}