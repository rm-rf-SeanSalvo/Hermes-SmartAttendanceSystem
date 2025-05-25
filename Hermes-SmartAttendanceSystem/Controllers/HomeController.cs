using Hermes_SmartAttendanceSystem.Models;
using Hermes_SmartAttendanceSystem.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;

namespace Hermes_SmartAttendanceSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(); // Login View
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var user = await _context.CheckUserLoginAsync(model.Username, model.Password);

            if (user == null)
            {
                ModelState.AddModelError(nameof(model.Username), "Invalid credentials.");
                ModelState.AddModelError(nameof(model.Password), "Invalid credentials.");
                return View(model);
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Username ?? string.Empty),
                new Claim(ClaimTypes.Role, user.UserRole ?? string.Empty),
                new Claim("FullName", $"{user.UserFN ?? ""} {user.UserLN ?? ""}"),
                new Claim("EmployeeID", user.EmployeeID.ToString())
            };

            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

            if (user.UserRole == "Manager")
                return RedirectToAction("ManagerDashboard", "Home");

            return RedirectToAction("Dashboard", "Employee");
        }

        [Authorize(Roles = "Manager")]
        public IActionResult ManagerDashboard()
        {
            var viewModel = new ManagerDashboardViewModel
            {
                ManagerName = "John Doe",
                TotalEmployees = 12,
                ShiftsToday = 3,
                LateEmployees = 1,
                PendingRequests = 2,
                RecentActivities = new List<RecentActivity>
                {
                    new RecentActivity { Type = "checkin", Message = "Alice checked in at 8:02 AM" },
                    new RecentActivity { Type = "late", Message = "Bob was late today" },
                    new RecentActivity { Type = "normal", Message = "Charlie completed his shift" }
                },
                ShiftCalendarEvents = new List<ShiftEvent>
                {
                    new ShiftEvent { Title = "Morning Shift", Date = new DateTime(2025, 5, 25, 8, 0, 0) },
                    new ShiftEvent { Title = "Evening Shift", Date = new DateTime(2025, 5, 26, 16, 0, 0) }
                }
            };

            return View(viewModel);
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        public IActionResult Privacy()
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
