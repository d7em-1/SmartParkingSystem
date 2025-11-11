using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SmartParkingWeb.Pages
{
    public class BookingDetailsModel : PageModel
    {
        [BindProperty(SupportsGet = true)] public string FullName { get; set; }
        [BindProperty(SupportsGet = true)] public string StudentId { get; set; }
        [BindProperty(SupportsGet = true)] public string CarType { get; set; }
        [BindProperty(SupportsGet = true)] public string Model { get; set; }
        [BindProperty(SupportsGet = true)] public string Color { get; set; }
        [BindProperty(SupportsGet = true)] public string PlateNumber { get; set; }
        [BindProperty(SupportsGet = true)] public string Department { get; set; }
        [BindProperty(SupportsGet = true)] public string SpotRow { get; set; }
        [BindProperty(SupportsGet = true)] public int SpotNumber { get; set; }

        public void OnGet()
        {
            // Â‰« „„ﬂ‰  ÷Ì› √Ì „‰ÿﬁ ≈÷«›Ì ≈–« «Õ Ã 
        }
    }
}