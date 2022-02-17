using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCore.Areas.DocumentInfo.Models;
using DotNetCore.Data.Entity;
using DotNetCore.Services.AuthService.Interfaces;
using DotNetCore.Services.Employee.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore.Areas.DocumentInfo.Controllers
{
    [Area("DocumentInfo")]
    public class DashboardController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly IUserInfoes userInfoes;
        private readonly IEmployeeService _employeeService;

        public DashboardController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<ApplicationRole> roleManager, IUserInfoes userInfoes,
             IEmployeeService employeeService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            this.userInfoes = userInfoes;
            _employeeService = employeeService;
        }
        public async Task<IActionResult> UserDashboard()
        {
            var userInfo = await userInfoes.GetUserInfoByUser(User.Identity.Name);
            var empInfo = await _employeeService.GetEmployeeInfoByApplicationId(userInfo.Id);
            var model = new DashboardViewModel
            {
                
            };
            return View(model);
        }
        public async Task<IActionResult> AdminDashboard()
        {
            var userInfo = await userInfoes.GetUserInfoByUser(User.Identity.Name);
            var empInfo = await _employeeService.GetEmployeeInfoByApplicationId(userInfo.Id);
            var model = new DashboardViewModel
            {
                
            };
            return View(model);
        }
    }
}