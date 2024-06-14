using DemoLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages.Pages;

public class Users : PageModel
{
    
    [BindProperty]
    public UserModel User { get; set; }
    
    public void OnGet()
    {
        
    }

    public IActionResult OnPost()
    {
        return RedirectToPage("./index");
    }
}