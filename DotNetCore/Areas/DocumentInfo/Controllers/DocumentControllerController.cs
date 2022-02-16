using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCore.Data.Entity;
using DotNetCore.Services.AuthService.Interfaces;
using DotNetCore.Services.Employee.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore.Areas.DocumentInfo.Controllers
{
    [Area("DocumentInfo")]
    public class DocumentController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly IUserInfoes userInfoes;
        private readonly IEmployeeService _employeeService;

        public DocumentController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<ApplicationRole> roleManager, IUserInfoes userInfoes,
             IEmployeeService employeeService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            this.userInfoes = userInfoes;
            _employeeService = employeeService;
        }
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}