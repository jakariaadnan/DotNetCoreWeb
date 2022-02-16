using DotNetCore.Data.Entity;
using DotNetCore.Models;
using DotNetCore.Services.Employee.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IEmployeeService _employeeService;

        public HomeController(UserManager<ApplicationUser> userManager, IEmployeeService employeeService)
        {
            _userManager = userManager;
            _employeeService = employeeService;
        }

        public async Task<IActionResult> Index()
        {
            //string userName = HttpContext.User.Identity.Name;
            //var user = await _userManager.FindByNameAsync(userName);
            //var roles = await _userManager.GetRolesAsync(user);

            //if (roles.Contains("Admin") || userName == "7001020888")
            //{
            //    if (user.UserName == "IGP")
            //    {
            //        return RedirectToAction("AssignmentPostMaster", "Assignment", new { Area = "Employee" });
            //    }
            //    else
            //    {
            //        return RedirectToAction(nameof(DashBoard));
            //    }

            //}
            //else if (roles.Contains("General User"))
            //{
            //    return RedirectToAction("Index", "EmployeeInfo", new { Area = "Employee" });
            //}
            //else
            //{
            //    return View();
            //}
            return RedirectToAction("LogIn", "Account", new { Area = "Auth" });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult DashBoard()
        {
            return View();
        }
        public IActionResult GridMenuPage()
        {


            return View();
        }

        public IActionResult GridMenuAddressPage()
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
