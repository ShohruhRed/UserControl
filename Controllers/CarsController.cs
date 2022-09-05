using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.FlowAnalysis;
using UserControl.Data;
using UserControl.Data.Services;
using UserControl.Models;

namespace UserControl.Controllers
{
    public class CarsController : Controller
    {
        private readonly ICarsService _service;

        public CarsController(ICarsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data =  await _service.GetAllAsync();

            return View(data);
        }

        //Get: Cars/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("CarName, ProfilePictureUrl, Description, StartDate")]Car car)
        {
            if (car.ProfilePictureUrl.Length == 0 && car.CarName.Length == 0 && car.Description.Length == 0)
            {
                return View(car);
            }
            await _service.AddAsync(car);
            return RedirectToAction(nameof(Index));
        }

        //Get: Cars/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var carDetails = await _service.GetByIdAsync(id);

            if (carDetails == null) return View("Empty");

            return View(carDetails);
            
        }
    }
}
