using Lena.Service.Base;
using Lena.Service.Option;
using Lena.WebUI.Models;
using LenaProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lena.WebUI.Controllers
{
    public class HomeController : Controller
    {
        FormService fs = new FormService();
        [AdminAuthentication] // giriş yapmamış kullanıcı denetimi
        public ActionResult Index() // açılışta formların listelenmesi
        {
            return View(fs.GetAll());

        }
        [HttpPost]
        public ActionResult Index(string exp) // form ismine göre arama
        {
            return View(fs.GetContaining(x => x.Name.Contains(exp) || exp == null).ToList());
        }
      
    }
}