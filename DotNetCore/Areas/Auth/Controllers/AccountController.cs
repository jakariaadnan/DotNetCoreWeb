using DotNetCore.Data.Entity;
using DotNetCore.Data.Entity.EmployeeInfos;
using AlphaManagement.Domain.AuthService.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCore.Services.Employee.Interfaces;
using DotNetCore.Areas.Auth.Models;

namespace AlphaManagement.Web.Areas.Auth.Controllers
{

    [Area("Auth")]
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly IUserInfoes userInfoes;
        private readonly IEmployeeService _employeeService;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<ApplicationRole> roleManager, IUserInfoes userInfoes,
             IEmployeeService employeeService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            this.userInfoes = userInfoes;
            _employeeService = employeeService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LogInViewModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
                var userInfos = await userInfoes.GetUserInfoByUser(model.Name);
                if (userInfos != null)
                {
                    var users = await _userManager.FindByIdAsync(userInfos.Id);
                    var roless = await _userManager.GetRolesAsync(users);
                    if (userInfos.isActive == 1 && roless.Contains("Admin"))
                    {
                        var result = await _signInManager.PasswordSignInAsync(model.Name, model.Password, model.RememberMe, lockoutOnFailure: true);
                        if (result.Succeeded)
                        {
                            var ip = Request.HttpContext.Connection.RemoteIpAddress.ToString();
                            var userAgent = Request.Headers["User-Agent"].ToString();
                            var mechineName = Environment.MachineName;

                            //UserLogHistory userLog = new UserLogHistory
                            //{
                            //    userId = model.Name,
                            //    logTime = DateTime.Now,
                            //    status = 1,
                            //    ipAddress = ip,
                            //    pcName = mechineName,
                            //    browserName = userAgent
                            //};

                            //await _accessLogHistoryService.SaveUserLogHistory(userLog);
                            var user = await _userManager.FindByIdAsync(userInfos.Id);
                            var roles = await _userManager.GetRolesAsync(user);

                            if (roles.Contains("Admin"))
                            {
                                if (user.UserName == "IGP")
                                {
                                    return RedirectToAction("Dashboard", "Home");
                                }
                                else
                                {
                                    return RedirectToAction("Dashboard", "Home");
                                }
                            }
                            else if (roles.Contains("General User"))
                            {
                                return RedirectToAction("Index", "EmployeeInfo", new { id = model.Name, Area = "Employee" });
                            }
                            else
                            {
                                return RedirectToLocal(returnUrl);
                            }


                        }
                        else
                        {
                            ModelState.AddModelError(string.Empty, "Invalid username or password.");
                            return View(model);
                        }
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Invalid username or password.");
                        return View(model);
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid username or password.");
                    return View(model);
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        [HttpGet]
        public IActionResult UserLogin(string returnUrl = null)
        {
            //LogInViewModel model = new LogInViewModel
            //{

            //};
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> UserLogin(LogInViewModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
                var userInfos = await userInfoes.GetUserInfoByUser(model.Name);
                if (userInfos != null)
                {
                    if (userInfos.isActive == 1)
                    {
                        var result = await _signInManager.PasswordSignInAsync(model.Name, model.Password, model.RememberMe, lockoutOnFailure: true);
                        if (result.Succeeded)
                        {
                            var ip = Request.HttpContext.Connection.RemoteIpAddress.ToString();
                            var userAgent = Request.Headers["User-Agent"].ToString();
                            var mechineName = Environment.MachineName;

                            //UserLogHistory userLog = new UserLogHistory
                            //{
                            //    userId = model.Name,
                            //    logTime = DateTime.Now,
                            //    status = 1,
                            //    ipAddress = ip,
                            //    pcName = mechineName,
                            //    browserName = userAgent
                            //};

                            //await _accessLogHistoryService.SaveUserLogHistory(userLog);
                            var user = await _userManager.FindByIdAsync(userInfos.Id);
                            var roles = await _userManager.GetRolesAsync(user);
                            return RedirectToAction("Index", "EmployeeInfo", new { id = model.Name, Area = "Employee" });


                        }
                        else
                        {
                            ModelState.AddModelError(string.Empty, "Invalid username or password.");
                            return View(model);
                        }
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Invalid username or password.");
                        return View(model);
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid username or password.");
                    return View(model);
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }


        [HttpGet]
        public IActionResult UserRegister()
        {
            RegisterViewModel model = new RegisterViewModel
            {

            };
            return View(model);
        }

        [HttpGet]
        public IActionResult ForgetPassword()
        {
            RegisterViewModel model = new RegisterViewModel
            {

            };
            return View(model);
        }



        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UserRegister(RegisterViewModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
                string username = HttpContext.User.Identity.Name;
                //var userinfo = await userInfoes.GetUserInfoByUser(username);
                var userinfo = await userInfoes.GetUserInfoByUser(model.Name);

                if (userinfo == null)
                {
                    string otpnumber = RandomString(4);
                    //userInfoes.DeleteUserInfoBeforeRegister(model.Name);
                    //UserInformation userInformation = new UserInformation
                    //{
                    //    userName = model.Name,
                    //    email = model.Email,
                    //    phoneNumber = model.PhoneNumber,
                    //    isVerified = 0,
                    //    statusId = 1,
                    //    password = model.Password,
                    //    bpNo = model.Name,
                    //    userRole = "General User",
                    //    otpCode = otpnumber,
                    //};
                    //int UserId = await userInfoes.SaveUserInfo(userInformation);

                    if (userinfo != null)
                    {

                    }
                    //return RedirectToLocal(returnUrl);
                    return RedirectToAction("UserOTPOption", new { id = 1, Area = "Auth" });
                }
                else
                {
                    model.errorMsg = "This " + model.Name + " no already exist, Please try with another bp";
                    return View(model);
                }

            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> UserOTPOptionSend(string email, string phone, string id)
        {
            try
            {
                var userInfo = await userInfoes.GetEmployeeInfoByUserName(id);

                RegisterViewModel model = new RegisterViewModel
                {
                    Email = email,
                    PhoneNumber = phone,
                    BPNo = id
                };
                return View(model);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        [HttpGet]
        public async Task<IActionResult> UserOTPOption(int id, string email, string phone)
        {
            try
            {
                //var userInfo = await userInfoes.GetUserInfoBeforeRegisterById(id);

                RegisterViewModel model = new RegisterViewModel
                {
                    //userInformation = userInfo
                };
                return View(model);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        //[HttpGet]
        //public async Task<IActionResult> UserEmailVerification(int userId, int smsTypeId)
        //{
        //    try
        //    {
        //        //var userInfo = await userInfoes.GetUserInfoBeforeRegisterById(userId);
        //        string newLine = Environment.NewLine;
        //        if (smsTypeId == 1)
        //        {
        //            string mailMessage = @"Dear " + userInfo.bpNo + "," + newLine + "Your OTP for BP Portfolio Account verification is " + userInfo.otpCode + "." + newLine + "Do not share it to anyone."+newLine+"" +
                        
        //                            "Thanks";
        //            //await _emailSenderService.SendEmail(userInfo.email, "Email Verification for Portfolio", mailMessage);
        //        }
        //        else
        //        {
        //            string smsMessage = string.Format(@"Dear {0}, Your OTP for BP Portfolio Account verification is {1}.Do not share it to anyone. Thanks", userInfo.bpNo, userInfo.otpCode);
        //            string otpNumber = userInfo.phoneNumber;
        //            if (!userInfo.phoneNumber.StartsWith("880"))
        //            {
        //                otpNumber = "88" + userInfo.phoneNumber;
        //            }
        //            else
        //            {
        //                otpNumber = userInfo.phoneNumber;
        //                userInfo.phoneNumber.Substring(0, 2);
        //            }


        //            await _sMSService.SendSMSAsync(otpNumber, smsMessage);
        //        }


        //        RegisterViewModel model = new RegisterViewModel
        //        {
        //            userInformation = userInfo,
        //            smsTypeId = smsTypeId
        //        };
        //        return View(model);
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }

        //}

        //[HttpGet]
        //public async Task<IActionResult> ResendOTPCode(int id, int smsTypeId)
        //{
        //    var userInfo = await userInfoes.GetUserInfoBeforeRegisterById(id);
        //    string otpCode = RandomString(4);
        //    userInfo.otpCode = otpCode;
        //    userInfo.statusId = 2;
        //    await userInfoes.SaveUserInfo(userInfo);
        //    string newLine = Environment.NewLine;
        //    if (smsTypeId == 1)
        //    {
        //        string mailMessage = @"Dear "+userInfo.bpNo+"," + newLine + "Your OTP for BP Portfolio Account verification is " + userInfo.otpCode + "." + newLine + "Do not share it to anyone." +
        //            "Thanks";
        //        await _emailSenderService.SendEmail(userInfo.email, "BP Portfolio Account Verification.", mailMessage);
        //    }
        //    else
        //    {
        //        string smsMessage = string.Format(@"Dear {0},Your OTP for BP Portfolio Account verification is {1}.Do not share it to anyone. Thanks", userInfo.bpNo, userInfo.otpCode);
        //        string otpNumber = userInfo.phoneNumber;
        //        if (!userInfo.phoneNumber.StartsWith("880"))
        //        {
        //            otpNumber = "88" + userInfo.phoneNumber;
        //        }
        //        else
        //        {
        //            otpNumber = userInfo.phoneNumber;
        //            userInfo.phoneNumber.Substring(0, 2);
        //        }
                    

        //        await _sMSService.SendSMSAsync(otpNumber, smsMessage);
        //    }


        //    //RegisterViewModel model = new RegisterViewModel
        //    //{
        //    //    userInformation = userInfo,
        //    //    smsTypeId = smsTypeId
        //    //};
        //    //string mailMessage = @"Hi," + newLine + "Please use this verification code to complete your sign in: " + userInfo.otpCode  +" ."+newLine+""+
        //    //                     ". Thanks for helping us keep your account secure.\n" +
        //    //                     "The PHQ Team";
        //    //await _emailSenderService.SendEmail(userInfo.email, "Email verification test for development", mailMessage);

        //    return Json(otpCode);
        //}

        //[HttpPost]
        //[AllowAnonymous]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> UserEmailVerification(RegisterViewModel model, string returnUrl = null)
        //{
        //    ViewData["ReturnUrl"] = returnUrl;
        //    var userInfo = await userInfoes.GetUserInfoBeforeRegisterById((int)model.UserId);
        //    if (ModelState.IsValid && model.UserOTPCode == userInfo.otpCode)
        //    {
        //        string username = HttpContext.User.Identity.Name;
        //        //var userinfo = await userInfoes.GetUserInfoByUser(username);
        //        //var userinfo = await userInfoes.GetUserInfoByUser(model.BPNo);

        //        var user = new ApplicationUser { UserName = model.Name, isActive = 1, Email = model.Email, bpNo = model.Name, PhoneNumber = model.PhoneNumber };
        //        var result = await _userManager.CreateAsync(user, model.Password);

        //        if (result.Succeeded)
        //        {
        //            //if (model.RoleId != "General User")
        //            //{
        //            //    await _userManager.AddToRoleAsync(user, "General User");
        //            //}
        //            //await _userManager.AddToRoleAsync(user, model.RoleId);
        //            await _userManager.AddToRoleAsync(user, "General User");
        //            IdentityUser temp = await _userManager.FindByNameAsync(model.Name);

        //            EmployeeInfo employee = new EmployeeInfo
        //            {
        //                employeeCode = model.Name,
        //                ApplicationUserId = temp.Id,
        //                mobileNumberPersonal = model.PhoneNumber,
        //                emailAddressPersonal = model.Email,
        //                isApproved=1
        //            };
        //            await _employeeService.SaveEmployeeInformation(employee);
        //            var resultl = await _signInManager.PasswordSignInAsync(model.Name, model.Password, false, lockoutOnFailure: true);
        //            //return RedirectToLocal(returnUrl);
        //            return RedirectToAction("Index", "EmployeeInfo", new { id = model.Name, Area = "Employee" });
        //        }
        //        AddErrors(result);
        //    }
        //    else
        //    {
        //        model.smsTypeId = model.smsTypeId;
        //        model.UserId = model.UserId;
        //        model.userInformation = userInfo;
        //        model.verifyMessage = "Invelid Code";
        //    }

        //    // If we got this far, something failed, redisplay form
        //    return View(model);
        //}


        //[HttpPost]
        //[AllowAnonymous]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> UserEmailVerificationforPassword(RegisterViewModel model, string returnUrl = null)
        //{
        //    ViewData["ReturnUrl"] = returnUrl;
        //    var userInfo = await userInfoes.GetUserInfoBeforeRegisterById((int)model.UserId);
        //    if (ModelState.IsValid && model.UserOTPCode == userInfo.otpCode)
        //    {
        //        string username = HttpContext.User.Identity.Name;
        //        var appId = await _userManager.FindByNameAsync(model.Name);
        //        return RedirectToAction("ResetPassword", "Account", new { id = appId.Id });
        //    }
        //    else
        //    {
        //        model.userInformation = userInfo;
        //        model.verifyMessage = "Invelid Code";
        //    }

        //    // If we got this far, something failed, redisplay form
        //    return View(model);
        //}



        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            string userId = HttpContext.User.Identity.Name;
            await _signInManager.SignOutAsync();
            var ip = Request.HttpContext.Connection.RemoteIpAddress.ToString();
            var userAgent = Request.Headers["User-Agent"].ToString();
            var mechineName = Environment.MachineName;
            //UserLogHistory userLog = new UserLogHistory
            //{
            //    userId = userId,
            //    logTime = DateTime.Now,
            //    status = 1,
            //    ipAddress = ip,
            //    pcName = mechineName,
            //    browserName = userAgent
            //};

            //await _accessLogHistoryService.SaveUserLogHistory(userLog);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> UserRoleCreate()
        {
            var roles = await _roleManager.Roles.ToListAsync();
            List<ApplicationRoleViewModel> lstRole = new List<ApplicationRoleViewModel>();
            foreach (var data in roles)
            {
                ApplicationRoleViewModel model = new ApplicationRoleViewModel
                {
                    RoleId = data.Id,
                    RoleName = data.Name
                };
                lstRole.Add(model);
            }
            ApplicationRoleViewModel viewModel = new ApplicationRoleViewModel
            {
                roleViewModels = lstRole
            };
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> UserIdentityRoleCreate([FromForm] ApplicationRoleViewModel model)
        {
            var user = new ApplicationRole(model.RoleName);
            IdentityResult result = await _roleManager.CreateAsync(user);

            return RedirectToAction(nameof(UserRoleCreate));
        }

        public async Task<IActionResult> AssaignRoleToUser()
        {
            string userName = User.Identity.Name;
            var roles = await _roleManager.Roles.Where(x => x.Name != "Super Admin").ToListAsync();
            var userInfo = await userInfoes.GetAllUserInfo();
            List<ApplicationRoleViewModel> lstRole = new List<ApplicationRoleViewModel>();
            foreach (var data in roles)
            {
                ApplicationRoleViewModel rolesModel = new ApplicationRoleViewModel
                {
                    RoleId = data.Id,
                    RoleName = data.Name
                };
                lstRole.Add(rolesModel);
            }

            ApplicationRoleViewModel model = new ApplicationRoleViewModel
            {
                roleViewModels = lstRole,
                userInfos = userInfo
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AssaignRoleToUser([FromForm] ApplicationRoleViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            //var user = await _userManager.FindByNameAsync(model.userName);
            var user = await _userManager.FindByIdAsync(model.userId);
            await userInfoes.DeleteUserRoleListByUserId(user.Id);
            if (model.roleIdList.Count() > 0)
            {
                for (int i = 0; i < model.roleIdList.Count(); i++)
                {
                    await _userManager.AddToRoleAsync(user, model.roleIdList[i]);
                }
            }

            return RedirectToAction(nameof(AssaignRoleToUser));
        }


        #region Helpers

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }

        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                //return Redirect(returnUrl);
                var userId = HttpContext.User.Identity.Name;

                return RedirectToAction("Index", "Home");
            }
            else
            {
                var userId = HttpContext.User.Identity.Name;
                return RedirectToAction("Index", "Home");
            }
        }
        #endregion

        #region API
        //[Route("global/api/getUserInfoList")]
        //[HttpGet]
        //public async Task<IActionResult> GetUserInfo()
        //{
        //    return Json(await userInfoes.GetUserInfo());
        //}

        [Route("global/api/GetUserRoleInfoByUserId/{Id}")]
        [HttpGet]
        public async Task<IActionResult> GetUserRoleInfoByUserId(string Id)
        {
            return Json(await userInfoes.GetRoleListByUserId(Id));
        }
        #endregion

        #region Password Change/Deactive/Active/MultipleRole

        //[HttpGet]
        //public async Task<IActionResult> UserEmailVerificationforPassword(string UserId, int smsTypeId)
        //{
        //    try
        //    {
        //        var userInfo = await userInfoes.GetUserInfoBeforeRegister(UserId);
        //        string newLine = Environment.NewLine;
        //        if (smsTypeId == 1)
        //        {
        //            string mailMessage = @"Hi," + newLine + "Please use this verification code to complete your sign in: " + userInfo.otpCode + "" + newLine + "" +

        //                            ". Thanks for helping us keep your account secure.\n" +
        //                            "The PHQ Team";
        //            await _emailSenderService.SendEmail(userInfo.email, "Email verification test for development", mailMessage);
        //        }
        //        else
        //        {
        //            string smsMessage = string.Format(@"{0} is Your Portfolio verivication code.", userInfo.otpCode);
        //            if (!userInfo.phoneNumber.StartsWith("880"))
        //                userInfo.phoneNumber = "88" + userInfo.phoneNumber;
        //            await _sMSService.SendSMSAsync(userInfo.phoneNumber, smsMessage);
        //        }


        //        RegisterViewModel model = new RegisterViewModel
        //        {
        //            userInformation = userInfo,
        //            smsTypeId = smsTypeId
        //        };
        //        return View(model);
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }

        //}

        [HttpGet]
        public IActionResult ResetPassword(string id)
        {


            ResetPasswordViewModel model = new ResetPasswordViewModel
            {
                applicationUserId = id
            };
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> ChangePassword(RegisterViewModel model)
        {

            var result = "error";

            if (!string.IsNullOrEmpty(model.OldPassword) && !string.IsNullOrEmpty(model.Password))
            {
                var username = User.Identity.Name;

                var user = await _userManager.FindByNameAsync(username);

                await _userManager.ChangePasswordAsync(user, model.OldPassword, model.Password);

                result = "success";
            }
            else
            {
                return Json(result);
            }

            return Json(result);
        }



        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var userName = await userInfoes.GetApplicationUserByUserId(model.applicationUserId);
                    ApplicationUser user = await _userManager.FindByNameAsync(userName.UserName);
                    var result = await _userManager.RemovePasswordAsync(user);
                    var results = await _userManager.AddPasswordAsync(user, model.Password);
                    if (results.Succeeded)
                    {
                        TempData["Success"] = "Password Changed Successfully!";
                        return Json("Success");
                    }
                    else
                    {
                        AddErrors(results);
                    }
                }
                return Json("Failed");
            }
            catch (Exception)
            {
                return Json("Try again");
            }
        }

        public async Task<IActionResult> UserStatusChange(string userId)
        {
            var status = "Failed";
            var user = await userInfoes.GetApplicationUserByUserId(userId);
            if (user.isActive == 1)
            {
                var results = await userInfoes.UserInactiveById(user.Id);
                if (results == 1)
                {
                    status = "Success";
                }
            }
            else
            {
                var results = await userInfoes.UserActiveById(user.Id);
                if (results == 1)
                {
                    status = "Success";
                }
            }
            return Json(status);
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> AssaignMultipleRoleToUser([FromForm] ApplicationRoleViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            try
            {
                var user = await _userManager.FindByIdAsync(model.userId);
                await userInfoes.DeleteUserRoleListByUserId(user.Id);
                if (model.roleIdList.Count() > 0)
                {
                    for (int i = 0; i < model.roleIdList.Count(); i++)
                    {
                        await _userManager.AddToRoleAsync(user, model.roleIdList[i]);
                    }
                }
                return Json("Success");
            }
            catch (Exception)
            {

                return Json("Failed");
            }
        }
        #endregion

        #region Forget Password
        [Route("global/api/GetEmployeeInfoByUserName")]
        [HttpGet]
        public async Task<IActionResult> GetEmployeeInfoByUserName(string userName)
        {
            var usernaname = await userInfoes.GetEmployeeInfoByUserName(userName);
            return Json(usernaname);
        }

        #endregion

    }
}


