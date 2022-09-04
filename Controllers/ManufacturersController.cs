using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.AccessControl;
using UserControl.Data;

namespace UserControl.Controllers
{
    public class ManufacturersController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public ManufacturersController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IActionResult>  Index()
        {
            var allManafacturers = await _dbContext.CarManufacturers.ToListAsync();
            return View(allManafacturers);
        }
    }
}
