using Microsoft.AspNetCore.Mvc;
using TAKS_Again.DAL;

namespace TAKS_Again.Areas.Manage.Controllers
{
    public class BannerController : Controller
    {
        readonly AppDbContext _context;
        readonly IWebHostEnvironment _env;
        public BannerController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_context.Brands.ToList());
        }
    }
}
