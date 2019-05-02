using Lena.Service.Option;
using LenaProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lena.WebUI.Controllers
{
    public class LoginController : Controller
    {
        UserService us = new UserService();

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User item)
        {
            if (us.Any(m => m.UserName==item.UserName && m.Password==item.Password))
            {
                User gelen = us.FindByUserName(item.UserName);
                Session["oturum"] = gelen;
            }
            else
            {
                ViewBag.Messages = "Bilgilerinizi kontrol ederek tekrar giriniz";
            }
            return View();
        }
        public ActionResult Logout()
        {
            Session.Abandon();
            return View();
        }
    }
}