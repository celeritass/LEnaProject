using Lena.Service.Option;
using Lena.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lena.WebUI.Controllers
{
    public class DisplayController : Controller
    {
        FormService fs = new FormService();
        [AdminAuthentication]
        public ActionResult Index()
        {            
            return View(fs.GetAll());
        }
    }
}