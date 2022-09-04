using Microsoft.AspNetCore.Mvc;
using UserControl.Data;

namespace UserControl.Controllers
{
    public class CarsController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public CarsController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var data = _dbContext.Cars.ToList();

            return View(data);
        }
    }
}
