using _16noyabr.DAL;
using _16noyabr.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _16noyabr.Controlers
{
    public class ProductController:Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult Detail(int? id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            Product product = _context.Products
                .Include(p=>p.Category)
                .Include(pi=>pi.ProductImages)
                .FirstOrDefault(p => p.Id == id);
            if (product is null)
            {
                return NotFound();
            }
            return View(product);
        }
}
}
