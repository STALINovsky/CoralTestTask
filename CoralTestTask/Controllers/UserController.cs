using System.Diagnostics;
using System.Threading.Tasks;
using CoralTestTask.Data;
using CoralTestTask.Data.UnitOfWork;
using CoralTestTask.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CoralTestTask.Controllers
{
    public class UserController : Controller
    {
        public IUnitOfWork UnitOfWork { get; set; }
        public CoralDbContext DbContext { get; set; }
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            UnitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Register(User user)
        {
            if (ModelState.IsValid)
            { 
                await UnitOfWork.UserRepository.Create(user);
                await UnitOfWork.SaveChangesAsync();
            }

            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
