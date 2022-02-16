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
using DotNetCore.Helpers;
using DotNetCore.Data.Entity.EmployeeInfos;

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
            var userInfo = await userInfoes.GetUserInfoByUser(User.Identity.Name);
            var empInfo = await _employeeService.GetEmployeeInfoByApplicationId(userInfo.Id);
            var model = new DocumentViewModel
            {
                documents = await _employeeService.GetEmployeeDocumentById(empInfo.Id)
            };
            return View(model);
        }
        public async Task<IActionResult> NewDocument()
        {
            var userInfo = await userInfoes.GetUserInfoByUser(User.Identity.Name);
            var empInfo = await _employeeService.GetEmployeeInfoByApplicationId(userInfo.Id);
            var model = new DocumentViewModel
            {
               
            };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NewDocument(DocumentViewModel model)
        {
            var userInfo = await userInfoes.GetUserInfoByUser(User.Identity.Name);
            var empInfo = await _employeeService.GetEmployeeInfoByApplicationId(userInfo.Id);
            if (model.document != null)
            {
                var fileName = "";
                string message = FileSave.SaveEmpAttachment(out fileName, model.document);
                var obj = new EmployeeDocument
                {
                    employeeId= empInfo.Id,
                    fileUrl= fileName,
                    documentName=model.documentName,
                    documentType=model.documentType,
                    date=DateTime.Now,
                    description=model.documentDescription
                };
                var save = await _employeeService.SaveEmployeeDocument(obj);
                if (save > 0)
                {
                    return RedirectToAction("Index", "Document");
                }
                else
                {
                    ModelState.AddModelError("File", "Unable To Save");
                    return View(model);
                }
            }
            else{
                ModelState.AddModelError("File", "File Not Found");
                return View(model);
            }
        }
    }
}