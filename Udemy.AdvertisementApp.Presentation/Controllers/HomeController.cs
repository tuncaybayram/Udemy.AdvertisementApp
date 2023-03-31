using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Udemy.AdvertisementApp.Business.Abstract.Services;
using Udemy.AdvertisementApp.Business.Concrete.Services;
using Udemy.AdvertisementApp.Presentation.Extensions;

namespace Udemy.AdvertisementApp.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAdvertisementManager _advertisementManager;
        private readonly IProvidedServiceManager _providedServiceManager;

        public HomeController(IProvidedServiceManager providedServiceManager, IAdvertisementManager advertisementManager)
        {
            _providedServiceManager = providedServiceManager;
            _advertisementManager = advertisementManager;
        }

        public async Task<IActionResult> Index()
        {
            var response=await _providedServiceManager.GetAllAsync();
            return this.ResponseView(response);

        }
        public async Task<IActionResult> HumanResource()
        {
            var response = await _advertisementManager.GetActivesAsync();
            return this.ResponseView(response);
        }

    }
}
