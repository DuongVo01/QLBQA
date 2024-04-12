using Microsoft.AspNetCore.Mvc;
using QLBQA.Data;

namespace QLBQA.Component
{
    public class Navbar : ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public Navbar(ApplicationDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            return View(_context.Categories.ToList());
        }
    }
}
