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
using DotNetCore.Services.RepositoryService.Interfaces;
using DotNetCore.Data.Entity.MasterData;

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
        private readonly IRepository<DocumentCategory> _repoDocumentCategory;
        private readonly IRepository<Department> _repoDepartment;

        public DocumentController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<ApplicationRole> roleManager, IUserInfoes userInfoes,
             IEmployeeService employeeService, IRepository<DocumentCategory> repoDocumentCategory, IRepository<Department> repoDepartment)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            this.userInfoes = userInfoes;
            _employeeService = employeeService;
            _repoDocumentCategory = repoDocumentCategory;
            _repoDepartment = repoDepartment;
        }

        public async Task<IActionResult> Index()
        {
            var userInfo = await userInfoes.GetUserInfoByUser(User.Identity.Name);
            var empInfo = await _employeeService.GetEmployeeInfoByApplicationId(userInfo.Id);
            var model = new DocumentViewModel
            {
                documents = await _employeeService.GetAllDocument()
            };
            return View(model);
        }
        public async Task<IActionResult> NewDocument()
        {
            var userInfo = await userInfoes.GetUserInfoByUser(User.Identity.Name);
            var empInfo = await _employeeService.GetEmployeeInfoByApplicationId(userInfo.Id);
            var model = new DocumentViewModel
            {
               documentCategory= _repoDocumentCategory.GetAll(),
                departments = _repoDepartment.GetAll()
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
                var refNum = await _employeeService.GetDocumentRefNumber();
                var master = new DocumentMaster
                {
                    Id=0,
                    departmentId=model.departmentId,
                    documentCategoryId=model.documentCategoryId,
                    documentName=model.documentName,
                    documentType=model.documentType,
                    employeeId= empInfo.Id,
                    documentNumber= refNum,
                    date=DateTime.Now,
                    keywords=model.keywords,
                    subject=model.subject


                };
                var saveMaster = await _employeeService.SaveDocumentMaster(master);
                var fileName = "";
                string message = FileSave.SaveEmpAttachment(out fileName, model.document);
                var obj = new DocumentDetails
                {
                    fileUrl= fileName
                };
                var save = await _employeeService.SaveDocumentDetails(obj);
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