using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages.Pages;

public class Messages : PageModel
{
    [BindProperty]
    public string Message { get; set; }
    
    public void OnGet()
    {
    }
}