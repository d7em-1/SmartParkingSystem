using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace SmartParkingWeb.Pages
{
    public class SelectSpotModel : PageModel
    {
        [BindProperty]
        [Required(ErrorMessage = "ÌÃ» «Œ Ì«— «·ﬁ”„")]
        public string Department { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "ÌÃ» «Œ Ì«— ’› «·„Ê«ﬁ›")]
        public string SpotRow { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "ÌÃ» «Œ Ì«— —ﬁ„ «·„Êﬁ›")]
        public int SpotNumber { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            //  „—Ì— «·»Ì«‰«  ≈·Ï ’›Õ… BookingDetails ⁄»— Query String
            return RedirectToPage("/BookingDetails", new
            {
                FullName = TempData["FullName"],
                StudentId = TempData["StudentId"],
                CarType = TempData["CarType"],
                Model = TempData["Model"],
                Color = TempData["Color"],
                PlateNumber = TempData["PlateNumber"],
                Department = Department,
                SpotRow = SpotRow,
                SpotNumber = SpotNumber
            });
        }
    }
}