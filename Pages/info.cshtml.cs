using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace razor.Pages
{
    public class inputModel : PageModel
    {
        public User user = new User();
        public void OnGet()
        {
        }
        public void OnPost(string name, string technologies, int age, string email)
        {
            user.name = name; user.email = email; user.age = age;
            user.technologies = technologies.Split(',').ToList();
            RedirectToPage("/info");
        }
    }
}
