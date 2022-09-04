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

        //public async Task<IActionResult> Filter(string searchString)
        //{
        //    var allMovies = await _service.GetAllAsync(n => n.Cinema);

        //    if (!string.IsNullOrEmpty(searchString))
        //    {
        //        //var filteredResult = allMovies.Where(n => n.Name.ToLower().Contains(searchString.ToLower()) || n.Description.ToLower().Contains(searchString.ToLower())).ToList();

        //        var filteredResultNew = allMovies.Where(n => string.Equals(n.Name, searchString, StringComparison.CurrentCultureIgnoreCase) || string.Equals(n.Description, searchString, StringComparison.CurrentCultureIgnoreCase)).ToList();

        //        return View("Index", filteredResultNew);
        //    }

        //    return View("Index", allMovies);
        //}
    }
}
