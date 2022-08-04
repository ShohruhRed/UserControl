using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using UserControl.Data;
using UserControl.Models;

namespace UserControl.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _dbContext;
        
        

        public AccountController(UserManager<ApplicationUser> userManager, ApplicationDbContext dbContext)
        {
            _userManager = userManager;
            _dbContext = dbContext;
        }

        [Authorize]
        [HttpGet]
        public IActionResult ListUsers()
        {
            var users = _userManager.Users;
            return View(users);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> DeleteSelected(string[] ids)
        {
            if (ids == null || ids.Length == 0)
            {
                ViewBag.ErrorMessage = $"User with Id = {ids} cannot be found";
                return View("NotFound");
            }

            else
            {
                //bind the task collection into list
                List<string> TaskIds = new List<string>(ids);

                for (var i = 0; i < TaskIds.Count(); i++)
                {
                    var user = await _userManager.FindByIdAsync(TaskIds[i]);
                    //remove the record from the database
                    _dbContext.Remove(user);
                    //call save changes action otherwise the table will not be updated
                    _dbContext.SaveChanges();
                }

                //redirect to index view once record is deleted
                return RedirectToAction("ListUsers");
            }
            
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> DisableSelected(string[] ids)
        {
            if (ids == null || ids.Length == 0)
            {
                ViewBag.ErrorMessage = $"User with Id = {ids} cannot be found";
                return View("NotFound");
            }

            else
            {
                //bind the task collection into list
                List<string> TaskIds = new List<string>(ids);

                Users users = new Users(_userManager);

                for (var i = 0; i < TaskIds.Count(); i++)
                {
                    users.LockUser(TaskIds[i], new DateTime(2222, 06, 06));
                }                
                
                
               
                //redirect to index view once record is deleted
                return RedirectToAction("ListUsers");
            }

        }

        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
