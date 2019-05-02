using LenaProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lena.WebUI.Models
{
    public class AdminAuthentication :AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (httpContext.Session["oturum"] != null)
            {
                User u = (User)httpContext.Session["oturum"];
                return true;
            }
            else
            {
                httpContext.Response.Redirect("/Login/Login");
                return false;
            }            

        }
    }
}