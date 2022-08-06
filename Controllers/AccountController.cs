using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UserControl.Data;

namespace UserControl.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _dbContext;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private ApplicationUser application;




        public AccountController(UserManager<ApplicationUser> userManager, ApplicationDbContext dbContext, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _dbContext = dbContext;
            _signInManager = signInManager;
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
                    var isAuth = User.Identity.Name.ToString();
                    var user = await _userManager.FindByIdAsync(TaskIds[i]);
                    //remove the record from the database
                    _dbContext.Remove(user);
                    //call save changes action otherwise the table will not be updated
                    _dbContext.SaveChanges();

                    if(user.UserName == isAuth)
                    {
                        var signOut = _signInManager.SignOutAsync();
                        signOut.Wait();
                    }

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

                var isAuth = User.Identity.Name.ToString();

                Users users = new Users(_userManager, _signInManager);

                for (var i = 0; i < TaskIds.Count(); i++)
                {
                    users.LockUser(TaskIds[i], new DateTime(2222, 06, 06), isAuth);
                }

                application = new ApplicationUser();

                if (application.LockoutEnabled)
                {
                    RedirectToAction("Account/Login");
                }


                //redirect to index view once record is deleted
                return RedirectToAction("ListUsers");
            }

        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> EnableSelected(string[] ids)
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

                Users users = new Users(_userManager,_signInManager);

                for (var i = 0; i < TaskIds.Count(); i++)
                {
                    users.UnlockUser(TaskIds[i]);
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
