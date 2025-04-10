using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

public class RegisterModel : PageModel
{
    [BindProperty]
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    
    [BindProperty]
    [Required]
    [DataType(DataType.PhoneNumber)]
    public string Phone { get; set; }

    public bool RegistrationSuccessful { get; set; }
    public bool RegistrationAttempted { get; set; }

    public void OnGet()
    {
        RegistrationSuccessful = false;
        RegistrationAttempted = false;
    }

    public IActionResult OnPost()
    {
        RegistrationAttempted = true;
        
        if (!ModelState.IsValid)
        {
            RegistrationSuccessful = false;
            return Page();
        }

        // Registration logic - For testing purposes, we'll assume registration is always successful
        RegistrationSuccessful = true;
        return Page();
    }
}