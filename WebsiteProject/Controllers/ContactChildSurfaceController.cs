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
        public ActionResult ContactChild(ContactChildModel contactsEntriesModel)
        {
            ViewBag.contactEntriesModel = contactsEntriesModel; 
            var contactChild = Services.ContentService.Create("contacto", 4362, "contactChild");
            contactChild.SetValue("nomeCompleto", contactsEntriesModel.NomeCompleto);
            contactChild.SetValue("email", contactsEntriesModel.Email);
            contactChild.SetValue("numerodeTelefone", contactsEntriesModel.NumerodeTelefone);
            contactChild.SetValue("orcamento", contactsEntriesModel.Orcamento);
            contactChild.SetValue("requisitos", contactsEntriesModel.Requisitos);

            Services.ContentService.Save(contactChild);

            return RedirectToCurrentUmbracoPage();
        }
    }
}