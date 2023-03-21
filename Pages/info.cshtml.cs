using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace razor.Pages
{
    public class InfoModel : PageModel
    {
        public User u = new();
        public void OnGet(User u)
        {
            this.u = u;
        }
    }
}
