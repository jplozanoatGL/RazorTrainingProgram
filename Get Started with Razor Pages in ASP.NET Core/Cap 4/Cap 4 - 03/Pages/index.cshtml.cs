using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel : PageModel
{
    public string Message { get; private set; } = "World";

    public void OnGet()
    {
        // Page load logic here
    }
}
