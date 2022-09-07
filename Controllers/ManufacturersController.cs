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
            
            ViewBag.Cars = new SelectList(manufacturerDropdownsData.Cars, "Id", "CarName");

            return View();

        }

        [HttpPost]
        public async Task<IActionResult> Create(NewManufacturerVM manufacturerVM)
        {
            if (!ModelState.IsValid)
            {
                var manufacturerDropdownsData = await _service.GetNewManufacturerDropdownsValues();
                
                ViewBag.Cars = new SelectList(manufacturerDropdownsData.Cars, "Id", "CarName");

                return View(manufacturerVM);
            }

            await _service.AddNewManufacturerAsync(manufacturerVM);
            return RedirectToAction(nameof(Index));
        }

        //GET: Movies/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var manufacturerDetails = await _service.GetManufacturerByIdAsync(id);
            if (manufacturerDetails == null) return View("NotFound");

            var response = new NewManufacturerVM()
            {
                Id = manufacturerDetails.Id,
                Name = manufacturerDetails.Name,
                Description = manufacturerDetails.Description,               
                FoundationDate = manufacturerDetails.FoundationDate,                
                ImageURL = manufacturerDetails.Logo,
                CarCategory = manufacturerDetails.CarCategory,
                
                CarIds = manufacturerDetails.Cars_CarManufacturers.Select(n => n.CarId).ToList(),
            };

            var movieDropdownsData = await _service.GetNewManufacturerDropdownsValues();           
            ViewBag.Cars = new SelectList(movieDropdownsData.Cars, "Id", "Name");

            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, NewManufacturerVM manufacturerVM)
        {
            if (id != manufacturerVM.Id) return View("NotFound");

            if (!ModelState.IsValid)
            {
                var manDropdownsData = await _service.GetNewManufacturerDropdownsValues();

                ViewBag.Cars = new SelectList(manDropdownsData.Cars, "Id", "Name");
               

                return View(manufacturerVM);
            }

            await _service.UpdateManufacturerAsync(manufacturerVM);
            return RedirectToAction(nameof(Index));
        }

        //Get: Cars/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var ManufacturerDetails = await _service.GetByIdAsync(id);

            if (ManufacturerDetails == null) return View("NotFound");

            return View(ManufacturerDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfiremed(int id)
        {
            var carDetails = await _service.GetByIdAsync(id);

            if (carDetails == null) return View("NotFound");


            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
