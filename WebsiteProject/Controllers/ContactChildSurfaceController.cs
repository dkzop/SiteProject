using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteProject.Models;
using Umbraco.Core.Composing.CompositionExtensions;
using Umbraco.Web.Mvc;

namespace WebsiteProject.Controllers
{
    public class ContactChildSurfaceController : SurfaceController
    {
        [HttpPost]
        public ActionResult ContactChild(ContactChildModel contactChildModel)
        {
            ViewBag.contactEntriesModel = contactChildModel; 
            var contactentries = Services.ContentService.GetById(4362);
            var contactChild = Services.ContentService.Create("contacto", 4362, "contactChild");
            contactChild.SetValue("nomeCompleto", contactChildModel.NomeCompleto);
            contactChild.SetValue("email", contactChildModel.Email);
            contactChild.SetValue("numerodeTelefone", contactChildModel.NumerodeTelefone);
            contactChild.SetValue("orcamento", contactChildModel.Orcamento);
            contactChild.SetValue("requisitos", contactChildModel.Requisitos);

            Services.ContentService.Save(contactChild);

            return RedirectToCurrentUmbracoPage();
        }
    }
}