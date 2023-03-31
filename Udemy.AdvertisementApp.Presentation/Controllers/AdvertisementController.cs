using Microsoft.AspNetCore.Mvc;

namespace Udemy.AdvertisementApp.Presentation.Controllers
{
    public class AdvertisementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
