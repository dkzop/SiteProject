
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;
using Umbraco.Web.Models;
using Umbraco.Core;
using System.Web.Mvc;
using System.Drawing;

namespace WebsiteProject.Models
{
    public class Home : ContentModel
    {
        public string Title
        {
            get { return Content.Value<string>("title"); }
        }

        public string Exemple
        {
            get { return Content.Value<string>("exemple"); }
        }

        //public Image Image
        //{
        //    get { return Content.Value<Image>("image"); }
        //}


        public Home(IPublishedContent content) : base(content)
        {
               
        }



    }
}