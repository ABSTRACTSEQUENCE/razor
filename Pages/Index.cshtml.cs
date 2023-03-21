using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace razor.Pages
{
	public class IndexModel : PageModel
	{
		public User user = new User();
		public string error { get; private set; } = "";

        public void OnGet()
		{}
		public IActionResult OnPost(string name, string technologies, int age, string email) 
		{
			if (string.IsNullOrEmpty(name) ||
				string.IsNullOrEmpty(email) ||
				string.IsNullOrEmpty(technologies))
			{ error = "Не все обязательные поля заполнены"; return null; }
			error = "";
			user.name = name;
			user.email = email;
			user.age = age;
            user.technologies = technologies.Split(new[]{',',' '}).ToList();
            return RedirectToPagePermanent("Info",user);
        }
	}
	public class User
	{
		public string name { get; set; } = "Данные отсутствуют";
		public string email { get; set; } = "Данные отсутствуют или некорректны";
		public int age { get; set; } = 0;
		public string about { get; set; } = "Данные отсутствуют";
		public List<string> technologies { get; set; } = new List<string>();
		public User(){}
		public User(string name, string email, int age, List<string> technologies, string? about)
		{
			string s = ".@";
			this.name = name;
			if(email.Contains<char>(s[0]) && email.Contains(s[1])) this.email = email;
			this.age = age;
			this.technologies = technologies;
			if (about != null) this.about = about;
		}
	}
}
