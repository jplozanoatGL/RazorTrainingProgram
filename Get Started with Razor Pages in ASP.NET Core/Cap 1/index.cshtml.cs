using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel : PageModel
{
    public string Message { get; private set; } = "World";

    public void OnGet()
    {
        // TODO: Change the message to "Tech Enthusiast"
        Message = "Tech Enthusiast";
    }
}