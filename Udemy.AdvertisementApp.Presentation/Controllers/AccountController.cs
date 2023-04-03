using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;
using Udemy.AdvertisementApp.Business.Abstract.Services;
using Udemy.AdvertisementApp.Presentation.Models;

namespace Udemy.AdvertisementApp.Presentation.Controllers
{
    public class AccountController : Controller
    {
        private readonly IGenderManager _genderManager;

        public AccountController(IGenderManager genderManager)
        {
            _genderManager = genderManager;
        }

        public async Task<IActionResult> SignUp()
        {
            var genders=await _genderManager.GetAllAsync();
            var model = new UserCreateModel
            {
                Genders = new SelectList(genders.ResultData,"Id","Definition")
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(UserCreateModel model)
        {
            
            return View(model);
        }
    }
}
