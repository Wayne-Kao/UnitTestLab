using Lab3.LoginSample.DataAccess;
using Lab3.LoginSample.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab3.LoginSample.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            this.TempData["CAPTCHA"] = new CaptchaDao().GetRandom();
            return View();
        }

        [HttpPost]
        public ActionResult Index(string account, string password, string captcha)
        {
            var isValid = new AuthenticationService().IsValid(account, password, captcha);

            if (isValid)
            {
                this.TempData["Name"] = account;
                return RedirectToAction("Account");
            }
            else
            {
                this.ViewBag.Message = string.Format("Login failed for user '{0}'", account);
                return View();
            }
        }

        [HttpGet]
        public ActionResult Account()
        {
            this.ViewBag.Name = this.TempData["Name"];
            return View();
        }
    }
}