#pragma checksum "G:\OPUS\Projecct With Identity\DotNetCore\DotNetCore\Areas\Auth\Views\Account\UserRegister.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9a0ccb3b354614f191a84b9beeea1bb90288471"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Auth_Views_Account_UserRegister), @"mvc.1.0.view", @"/Areas/Auth/Views/Account/UserRegister.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Auth/Views/Account/UserRegister.cshtml", typeof(AspNetCore.Areas_Auth_Views_Account_UserRegister))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "G:\OPUS\Projecct With Identity\DotNetCore\DotNetCore\Areas\Auth\Views\_ViewImports.cshtml"
using DotNetCore;

#line default
#line hidden
#line 2 "G:\OPUS\Projecct With Identity\DotNetCore\DotNetCore\Areas\Auth\Views\_ViewImports.cshtml"
using DotNetCore.Areas.Auth.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9a0ccb3b354614f191a84b9beeea1bb90288471", @"/Areas/Auth/Views/Account/UserRegister.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a147c17b5552f90c21effdbb75c304d9a058fedb", @"/Areas/Auth/Views/_ViewImports.cshtml")]
    public class Areas_Auth_Views_Account_UserRegister : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegisterViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/logo/Ploice 01.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:80px;height:80px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form mt-5 contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Auth", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserRegister", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/plugins/sweet-alert/sweetalert2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/pages/jquery.sweet-alert.init.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/plugins/sweet-alert/sweetalert2.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "G:\OPUS\Projecct With Identity\DotNetCore\DotNetCore\Areas\Auth\Views\Account\UserRegister.cshtml"
  
    ViewData["Title"] = "UserRegister";
    Layout = "~/Views/Shared/_Init_Layout.cshtml";

#line default
#line hidden
            BeginContext(126, 501, true);
            WriteLiteral(@"<section class=""bg-login"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12 col-sm-12"">
                <div class=""wrapper-page"">
                    <div class=""account-pages"">
                        <div class=""account-box"">
                            <div class=""card m-b-30"">
                                <div class=""card-body"">
                                    <div class=""card-title text-center"">
                                        ");
            EndContext();
            BeginContext(627, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c9a0ccb3b354614f191a84b9beeea1bb902884719310", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(715, 178, true);
            WriteLiteral("\r\n                                        <h5 class=\"mt-3\"><b>BP Portfolio Registration</b></h5>\r\n                                    </div>\r\n                                    ");
            EndContext();
            BeginContext(893, 4938, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9a0ccb3b354614f191a84b9beeea1bb9028847110914", async() => {
                BeginContext(1011, 479, true);
                WriteLiteral(@"
                                        <div class=""form-group "">
                                            <div class=""col-sm-12"">
                                                <input class=""form-control form-control-line"" type=""text"" id=""bpNo"" autocomplete=""off"" onkeyup=""getPIMSData()"" onchange=""getPIMSData()"" data-parsley-length=""[10,10]"" name=""Name"" placeholder=""BP No (User Name)"" required>
                                                <span style=""color:red"">");
                EndContext();
                BeginContext(1491, 14, false);
#line 23 "G:\OPUS\Projecct With Identity\DotNetCore\DotNetCore\Areas\Auth\Views\Account\UserRegister.cshtml"
                                                                   Write(Model.errorMsg);

#line default
#line hidden
                EndContext();
                BeginContext(1505, 3324, true);
                WriteLiteral(@"</span>
                                            </div>
                                        </div>
                                        <div class=""form-group "">
                                            <div class=""col-sm-12"">
                                                <input class=""form-control form-control-line"" id=""fullName"" type=""text"" placeholder=""Full Name"" readonly>
                                            </div>
                                        </div>
                                        <div class=""form-group "">
                                            <div class=""col-sm-12"">
                                                <input class=""form-control form-control-line"" type=""email"" id=""Email1"" placeholder=""Email"" parsley-type=""email"" readonly required>
                                                <input type=""hidden"" id=""Email"" name=""Email"" parsley-type=""email"" readonly required>
                                            </div>
                      ");
                WriteLiteral(@"                  </div>

                                        <div class=""form-group "">
                                            <div class=""col-sm-12"">
                                                <input class=""form-control form-control-line"" type=""text"" id=""PhoneNumber1"" placeholder=""Mobile"" readonly required data-parsley-length=""[11,11]"">
                                                <input type=""hidden"" name=""PhoneNumber"" id=""PhoneNumber"" required data-parsley-length=""[11,11]"">
                                            </div>
                                        </div>

                                        <div class=""form-group "">
                                            <div class=""col-sm-12"">
                                                <input class=""form-control form-control-line"" autocomplete=""off"" id=""password"" name=""Password"" type=""password"" placeholder=""Password"">
                                                <ul style=""list-style:none"" id=""pass"">
         ");
                WriteLiteral(@"                                           <li class=""text-danger"">Password must be 6 character.</li>
                                                    <li class=""text-danger"">Password must be contain 1 numeric character. </li>
                                                </ul>
                                            </div>
                                        </div>

                                        <div class=""form-group "">
                                            <div class=""col-sm-12"">
                                                <input class=""form-control form-control-line"" type=""password"" minlength=""6"" name=""ConfirmPassword"" placeholder=""Confirm Password"" required data-parsley-equalto=""#password"">
                                            </div>
                                        </div>

                                        <div class=""form-group"">
                                            <div class=""col-12"">
                                           ");
                WriteLiteral("     <label class=\"cr-styled\">\r\n                                                    <input type=\"checkbox\" checked>\r\n                                                    <i class=\"fa\"></i>\r\n                                                    I accept <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 4829, "\"", 4836, 0);
                EndWriteAttribute();
                BeginContext(4837, 987, true);
                WriteLiteral(@">Terms and Conditions</a>
                                                </label>
                                            </div>
                                        </div>

                                        <div class=""form-group"">
                                            <div class=""col-sm-12 mt-4"">
                                                <button class=""btn btn-primary btn-block"" id=""signUp"" type=""submit"">Sign Up</button>
                                            </div>
                                        </div>

                                        <div class=""form-group"">
                                            <div class=""col-sm-12 mt-4 text-center"">
                                                <span>Already have an account ? <a href=""/Auth/Account/UserLogin"">Login</a></span>

                                            </div>
                                        </div>

                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5831, 230, true);
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n</section>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(6078, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(6084, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9a0ccb3b354614f191a84b9beeea1bb9028847119390", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6148, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(6154, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9a0ccb3b354614f191a84b9beeea1bb9028847120646", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6212, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(6218, 90, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c9a0ccb3b354614f191a84b9beeea1bb9028847121903", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6308, 1921, true);
                WriteLiteral(@"
    <script type=""text/javascript"">

        $('#password').keyup(function () {
            var data = this.value;
            if (data.length >= 6) {
                $('#pass').hide();
            } else {
                $('#pass').show();
            }
        })


        function getPIMSData() {
            var bpNo = $('#bpNo').val().trim();

            if (bpNo.length == 10) {
                Common.Ajax('GET', 'https://pims.police.gov.bd:8443/pimslive/webpims/opus/bpdetails/BP' + bpNo, [], 'json', pimsdata, false);
            } else {
                $('#fullName').val('');
                $('#Email').val('');
                $('#PhoneNumber').val('');
                $('#Email1').val('');
                $('#PhoneNumber1').val('');
            }
        }
        var rank = ['আইজিপি', 'এডিশনাল আইজি', 'অ্যাডিশনাল আইজি', 'ডিআইজি', 'এডিশনাল ডিআইজি', 'অ্যাডিশনাল ডিআইজি', 'এসপি', 'এডিশনাল এসপি', 'এএসপি', 'অ্যাডিশনাল এসপি']
        var joiningRank = ['এএসপি']
        function");
                WriteLiteral(@" pimsdata(res) {
            if (res.items[0] == null) {
                console.log(res.items[0])
                return false;
            }
            var mobNum = """";
            var first3 = """";
            var last3 = """";
            var mask = """";
            var email = """";
            var n = """";
            var firstPart = """";
            var firstPartEmail = """";
            var lastPart = """";
            var maskEmail = """";
            if (res.items[0].phone != null) {
                mobNum = res.items[0].phone;
                first3 = mobNum.substring(0, 3);
                last3 = mobNum.substring(mobNum.length - 3);
                mask = mobNum.substring(3, mobNum.length - 3).replace(/\d/g, ""*"");
            }           
            if (res.items[0].email != null) {
                email = res.items[0].email;
                n = email.indexOf(""");
                EndContext();
                BeginContext(8230, 1680, true);
                WriteLiteral(@"@"");
                firstPart = email.substring(0, n);
                firstPartEmail = firstPart.substring(n - 3, n);
                lastPart = email.substring(n);
                maskEmail = firstPart.substring(0, firstPart.length - 3).replace(/[a-z]/g, '*');
            }
            
            $('#fullName').val(res.items[0].english_name);
            $('#PhoneNumber1').val(first3 + mask + last3);
            $('#Email1').val(maskEmail + firstPartEmail + lastPart);
            $('#Email').val(res.items[0].email);
            $('#PhoneNumber').val(res.items[0].phone);
            if (jQuery.inArray(res.items[0].present_rank, rank) !== -1 || jQuery.inArray(res.items[0].police_joining_rank, joiningRank) !== -1) {
                document.getElementById(""signUp"").disabled = false;
            }
            else {
                swal({
                    title: 'Not Selected', text: `You are not selected for registration!`, type: 'warning', showCancelButton: true, confirmButtonColor: '#0");
                WriteLiteral(@"07ACC', cancelButtonColor: '#d33', confirmButtonText: `OK!`
                }).then(function () {
                    document.getElementById(""signUp"").disabled = true;
                    $('#bpNo').val('');
                    $('#fullName').val('');
                    $('#Email').val('');
                    $('#PhoneNumber').val('');
                    $('#Email1').val('');
                    $('#PhoneNumber1').val('');
                });                
            }            
        }

        $(document).ready(function () {
            $('#pass').hide();
            $('form').parsley();

        });

    </script>
");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
