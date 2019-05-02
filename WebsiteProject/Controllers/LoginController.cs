using System.Web.Mvc;
using System.Web.Security;
using Umbraco.Web.Mvc;
using WebsiteProject.Models;

namespace WebsiteProject.Controllers
{
    public class LoginController : SurfaceController
    {
        [HttpGet]
        public ActionResult Login(string hello)
        {
            ViewBag.hello = hello;
            return PartialView();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Login model)
        {
            if (ModelState.IsValid)
            {
                if (Membership.ValidateUser(model.Username, model.Password))
                {
                    FormsAuthentication.SetAuthCookie(model.Username, true);
                }
                else
                {
                    ModelState.AddModelError("", "O login está inválido");
                }
            }
            return PartialView(model);
        }
    }
}