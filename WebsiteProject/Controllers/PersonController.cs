using Microsoft.AspNet.Identity;
using System.Web.Mvc;
using System.Web.Security;
using Umbraco.Web.Mvc;
using WebsiteProject.Models;

namespace WebsiteProject.Controllers
{
    public class PersonController : RenderMvcController
    {
        [HttpGet]
        public ActionResult Person()
        {
            return View(CurrentPage);
        }

        [HttpPost]
        public ActionResult Person(PersonModel model)
        {
            return View(model);
        }
    }
}