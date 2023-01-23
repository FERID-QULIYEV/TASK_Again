using Microsoft.AspNetCore.Mvc;
using TAKS_Again.DAL;
using TAKS_Again.Models;
using TAKS_Again.ViewModels;

namespace TAKS_Again.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class CategoryController: Controller
    {
        readonly AppDbContext _context;
        readonly IWebHostEnvironment _env;
        public CategoryController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateCategoryVM CategoryVm )
        {
            if (!ModelState.IsValid) return View();
            IFormFile file = CategoryVm.ImageUrl;
            if (!file.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("Image", "Duzgun sekil yukle");
                return View();
            }
            if (!(CategoryVm.ImageUrl.Length / 1024 / 1024 < 2))
            {
                ModelState.AddModelError("Image", "Sekilin hecmi 2mb-dan cox olmaz");
                return View();
            }
            string fileName = Guid.NewGuid() + file.FileName;
            using (var stream = new FileStream(Path.Combine(_env.WebRootPath, "assets", "images", "brand", fileName), FileMode.Create))
            {
                file.CopyTo(stream);
            }
            Category category = new Category {ImageUrl=fileName};
            _context.Categories.Add(category);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Update(int? id)
        {
            if (id == null || id == 0) return BadRequest();
            Category category = _context.Categories.Find(id);
            if (category is null) return NotFound();
            return View(category);
        }
        [HttpPost]
        public IActionResult Update(int? id, Category category)
        {
            if (id == null || id == 0 || id != category.Id || category is null) return BadRequest();
            if (!ModelState.IsValid) return View();
            Category exist = _context.Categories.Find(category.Id);
            exist.ImageUrl = category.ImageUrl;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int? id)
        {
            if (id is null) return BadRequest();

            Category category = _context.Categories.Find(id);
            if (category is null) return NotFound();
            _context.Categories.Remove(category);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
