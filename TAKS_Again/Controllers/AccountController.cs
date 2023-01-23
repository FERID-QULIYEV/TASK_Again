using Microsoft.AspNetCore.Mvc;
using TAKS_Again.Models;
using TAKS_Again.ViewModels.User;

namespace TAKS_Again.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(UserRegisterVM registerVM)
        {
            if(!ModelState.IsValid)return NotFound();
            AppUser user = new AppUser();
            {
                FirstName = registerVM.Name;
                Las
            }
            _usem
            return Json(registerVM);
        }
    }
}
