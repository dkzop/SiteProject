﻿using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using Umbraco.Web.Mvc;
using WebsiteProject.Models;


namespace WebsiteProject.Controllers
{
    public class RegisterController : SurfaceController
    {

        [HttpGet]
        public ActionResult Register()
        {
            return PartialView();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                Membership.CreateUser(model.Username, model.Password, model.Email);
                return Redirect("http://localhost:50161/home/");
            }
            return PartialView();
        }
    }
}