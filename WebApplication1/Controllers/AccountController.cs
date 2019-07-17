using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SimpleWebApp.Models;

namespace SimpleWebApp.Controllers
{
    public class AccountController : Controller
    {     
        [HttpPost]        
        public ActionResult LogOn(LogOnModel model)
        {
            var charArray = model.UserName.ToCharArray();
            Array.Reverse(charArray);
            var reversedUsername = new string(charArray);
            if (reversedUsername == model.Password) {
                Session["User"] = model.UserName;
                return Json(new { Success = true });
            }
            return Json(new { Success = false });

        }

        public ActionResult LogOff()
        {
            Session.Remove("User");
            Session.Contents.RemoveAll();
            Session.RemoveAll();

            return Json(new { Success = true });
        }

    }
}
