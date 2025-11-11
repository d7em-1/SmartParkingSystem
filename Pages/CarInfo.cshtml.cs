using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace SmartParkingWeb.Pages
{
    public class CarInfoModel : PageModel
    {
        [BindProperty]
        [Required(ErrorMessage = "‰Ê⁄ «·”Ì«—… „ÿ·Ê»")]
        [RegularExpression(@"^[A-Za-z\u0600-\u06FF\s]+$", ErrorMessage = "‰Ê⁄ «·”Ì«—… ÌÃ» √‰ ÌÕ ÊÌ ⁄·Ï √Õ—› ›ﬁÿ (⁄—»Ì √Ê ≈‰Ã·Ì“Ì)")]
        public string CarType { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "«·„ÊœÌ· „ÿ·Ê»")]
        public string Model { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "«··Ê‰ „ÿ·Ê»")]
        [RegularExpression(@"^[A-Za-z\u0600-\u06FF\s]+$", ErrorMessage = "«··Ê‰ ÌÃ» √‰ ÌÕ ÊÌ ⁄·Ï √Õ—› ›ﬁÿ (⁄—»Ì √Ê ≈‰Ã·Ì“Ì)")]
        public string Color { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "—ﬁ„ «··ÊÕ… „ÿ·Ê»")]
        [RegularExpression(@"^[A-Za-z0-9\u0600-\u06FF]+$", ErrorMessage = "—ﬁ„ «··ÊÕ… ÌÃ» √‰ ÌÕ ÊÌ ⁄·Ï √Õ—› Ê√—ﬁ«„ ›ﬁÿ")]
        public string PlateNumber { get; set; }

        public void OnGet() { }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            // Õ›Ÿ »Ì«‰«  «·”Ì«—… ›Ì TempData
            TempData["CarType"] = CarType;
            TempData["Model"] = Model;
            TempData["Color"] = Color;
            TempData["PlateNumber"] = PlateNumber;

            // «·«‰ ﬁ«· ≈·Ï ’›Õ… «Œ Ì«— «·ﬁ”„ Ê«·„Êﬁ›
            return RedirectToPage("/SelectSpot");
        }
    }
}