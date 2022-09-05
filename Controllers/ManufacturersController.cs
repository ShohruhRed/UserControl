using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Security.AccessControl;
using UserControl.Data;
using UserControl.Data.Services;
using UserControl.ViewModels;

namespace UserControl.Controllers
{
    public class ManufacturersController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IManufacturersService _service;

        public ManufacturersController(IManufacturersService service)
        {
            _service = service;
        }
        public async Task<IActionResult>  Index()
        {
            var allManafacturers = await _service.GetAllAsync();
            return View(allManafacturers);
        }

        public async Task<IActionResult> Details(int id)
        {
            var movieDetail = await _service.GetManufacturerByIdAsync(id);
            return View(movieDetail);
        }

        public async Task<IActionResult> Filter(string searchString)
        {
            var allMovies = await _service.GetAllAsync(n => n.Name);

            if (!string.IsNullOrEmpty(searchString))
            {
                //var filteredResult = allMovies.Where(n => n.Name.ToLower().Contains(searchString.ToLower()) || n.Description.ToLower().Contains(searchString.ToLower())).ToList();

                var filteredResultNew = allMovies.Where(n => string.Equals(n.Name, searchString, StringComparison.CurrentCultureIgnoreCase) || string.Equals(n.Description, searchString, StringComparison.CurrentCultureIgnoreCase)).ToList();

                return View("Index", filteredResultNew);
            }

            return View("Index", allMovies);
        }

        public async Task<IActionResult> Create()
        {
            var manufacturerDropdownsData = await _service.GetNewManufacturerDropdownsValues();
            
            ViewBag.Cars = new SelectList(manufacturerDropdownsData.Cars, "CarId", "Name");

            return View();

        }

        [HttpPost]
        public async Task<IActionResult> Create(NewManufacturerVM manufacturerVM)
        {
            if (!ModelState.IsValid)
            {
                var movieDropdownsData = await _service.GetNewManufacturerDropdownsValues();
                
                ViewBag.Cars = new SelectList(movieDropdownsData.Cars, "CarId", "CarName");

                return View(manufacturerVM);
            }

            await _service.AddNewManufacturerAsync(manufacturerVM);
            return RedirectToAction(nameof(Index));
        }
    }
}
