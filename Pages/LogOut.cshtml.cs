using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FormSubmission.Pages
{
    public class LogOutModel : PageModel
    {
		private readonly SignInManager<IdentityUser> signInManager;

		public LogOutModel(SignInManager<IdentityUser> signInManager)
        {
			this.signInManager = signInManager;
		}
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostLogoutAsync()
        {
            await signInManager.SignOutAsync();
            return RedirectToPage("LogIn");
        }
        public IActionResult OnPostDontLogutAsync()
        {
			return RedirectToPage("LogIn");
		}
    }
}
