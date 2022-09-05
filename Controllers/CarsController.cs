using Microsoft.AspNetCore.Mvc;
using UserControl.Data;
using UserControl.Data.Services;

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
            var data =  await _service.GetAll();

            return View(data);
        }

        //Get: Cars/Create
        public IActionResult Create()
        {
            return View();
        }
    }
}
