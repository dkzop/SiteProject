using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;
using WebsiteProject.Models;

namespace WebsiteProject.Controllers
{
    public class ContactChildController : RenderMvcController
    {

        [HttpGet]
        public ActionResult ContactChild (ContactChildModel contactChild)
        {

            return CurrentTemplate(contactChild);
        }
    }
}