using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace SmartParkingWeb.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        [Required(ErrorMessage = "«”„ «·„” Œœ„ „ÿ·Ê»")]
        public string Username { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "ﬂ·„… «·„—Ê— „ÿ·Ê»…")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public void OnGet() { }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            // Õﬁﬁ »”Ìÿ )
            if (Username == "admin" && Password == "1234")
            {
                // Õ›Ÿ »Ì«‰«  «› —«÷Ì… ›Ì TempData
                TempData["FullName"] = "«·«”„ «·«› —«÷Ì";
                TempData["StudentId"] = "123456";
                TempData["Email"] = "example@domain.com";

                return RedirectToPage("/CarInfo");
            }

            ModelState.AddModelError(string.Empty, "«”„ «·„” Œœ„ √Ê ﬂ·„… «·„—Ê— €Ì— ’ÕÌÕ…");
            return Page();
        }
    }
}