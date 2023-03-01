using Captcha_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CaptchaMvc.Attributes;
using CaptchaMvc.HtmlHelpers;

namespace Captcha_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(RegistrationModel objRegistrationModel)
        {
            if (!this.IsCaptchaValid(""))
            {
                ViewBag.ErrorMessage = "Captcha is not valid!";
                return View("Index", objRegistrationModel);
            }
            return Content("LOGIN SUCCESFULLY!");
        }
    }
}