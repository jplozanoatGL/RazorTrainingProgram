using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

public class ContactModel : PageModel
{
    [BindProperty]
    [Required]
    [StringLength(50, MinimumLength = 3)]
    public string ContactName { get; set; }

    [BindProperty]
    [Required]
    [Phone]
    public string PhoneNumber { get; set; }

    public bool SubmissionSuccessful { get; set; }
    public bool SubmissionAttempted { get; set; }

    public void OnGet()
    {
        SubmissionSuccessful = false;
        SubmissionAttempted = false;
    }

    public IActionResult OnPost()
    {
        SubmissionAttempted = true;
        
        if (!ModelState.IsValid)
        {
            SubmissionSuccessful = false;
            return Page();
        }

        // Submission logic - For testing purposes, we'll assume submission is always successful
        SubmissionSuccessful = true;
        return Page();
    }
}