using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Web.Models;
using Umbraco.Core.Models.PublishedContent;
using System.Web.Mvc;
using Umbraco.Web;

namespace WebsiteProject.Models
{
    public class Footer : ContentModel
    {
        public string LeftFooterTitle
        {
            get { return Content.Value<string>("leftFooterTitle"); }
        }

        public string LeftFooterText
        {
            get { return Content.Value<string>("LeftFooterText"); }
        }

        public string CenterLeftFooterTitle
        {
            get { return Content.Value<string>("CenterLeftFooterTitle"); }
        }

        public string CenterLeftFootersubTitle
        {
            get { return Content.Value<string>("CenterLeftFootersubTitle"); }
        }


        public string CenterLeftFooterText
        {
            get { return Content.Value<string>("CenterLeftFooterText"); }
        }

        public string CenterRightFooterTitle
        {
            get { return Content.Value<string>("CenterRightFooterTitle"); }
        }

        public string CenterRightFooterText
        {
            get { return Content.Value<string>("CenterRightFooterText"); }
        }

        public string RightFooterTitle
        {
            get { return Content.Value<string>("RightFooterTitle"); }
        }

        public string Adress
        {
            get { return Content.Value<string>("adress"); }
        }

        public string CityandPostalCode
        {
            get { return Content.Value<string>("cityandPostalCode"); }
        }

        public string Country
        {
            get { return Content.Value<string>("country"); }
        }

        public string PhoneNumber
        {
            get { return Content.Value<string>("phoneNumber"); }
        }

        public string Fax
        {
            get { return Content.Value<string>("fax"); }
        }

        public Footer(IPublishedContent content) : base(content)
        {

        }
    }
}