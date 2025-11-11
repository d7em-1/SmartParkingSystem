using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

public class RegisterModel : PageModel
{
    [BindProperty, Required(ErrorMessage = "«·«”„ „ÿ·Ê»")]
    public string FullName { get; set; }

    [BindProperty, Required(ErrorMessage = "«”„ «·„” Œœ„ „ÿ·Ê»")]
    public string UserName { get; set; }

    [BindProperty, Required(ErrorMessage = "ﬂ·„… «·„—Ê— „ÿ·Ê»…"), DataType(DataType.Password)]
    public string Password { get; set; }

    [BindProperty, Required(ErrorMessage = " √ﬂÌœ ﬂ·„… «·„—Ê— „ÿ·Ê»"), Compare("Password", ErrorMessage = "ﬂ·„… «·„—Ê— €Ì— „ ÿ«»ﬁ…")]
    public string ConfirmPassword { get; set; }

    [BindProperty, Required(ErrorMessage = "«·—ﬁ„ «·Ã«„⁄Ì „ÿ·Ê»")]
    public string StudentId { get; set; }

    [BindProperty, Required(ErrorMessage = "«·»—Ìœ «·≈·ﬂ —Ê‰Ì „ÿ·Ê»"), EmailAddress(ErrorMessage = "’Ì€… «·»—Ìœ «·≈·ﬂ —Ê‰Ì €Ì— ’ÕÌÕ…")]
    public string Email { get; set; }

    [BindProperty]
    public IFormFile UniversityCard { get; set; }

    public void OnGet() { }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
            return Page();

        // —›⁄ «·’Ê—… ≈–« „ÊÃÊœ…
        if (UniversityCard != null)
        {
            var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads");
            if (!Directory.Exists(uploadsFolder))
                Directory.CreateDirectory(uploadsFolder);

            var filePath = Path.Combine(uploadsFolder, UniversityCard.FileName);
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                UniversityCard.CopyTo(stream);
            }
        }

        // Õ›Ÿ »Ì«‰«  «·„” Œœ„ ›Ì TempData
        TempData["FullName"] = FullName;
        TempData["StudentId"] = StudentId;
        TempData["Email"] = Email;

        TempData["SuccessMessage"] = " „ «· ”ÃÌ· »‰Ã«Õ! Ì„ﬂ‰ﬂ  ”ÃÌ· «·œŒÊ· «·¬‰.";

        // «·«‰ ﬁ«· ≈·Ï ’›Õ…  ”ÃÌ· «·œŒÊ·
        return RedirectToPage("/Login");
    }
}