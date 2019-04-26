using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.Web.Models;

namespace WebsiteProject.Models
{
    public class AboutUs : ContentModel
    {
        public string Title
        {
            get { return Content.Value<string>("title"); }
        }

        public string FirstTitle
        {
            get { return Content.Value<string>("firstTitle"); }
        }

        public string FirstText
        {
            get { return Content.Value<string>("firstTitle"); }
        }

        public string SecondTitle
        {
            get { return Content.Value<string>("secondTitle"); }
        }

        public string SecondText
        {
            get { return Content.Value<string>("secondText"); }
        }

        public string ThirdTitle
        {
            get { return Content.Value<string>("thirdTitle"); }
        }

        public string ThirdText
        {
            get { return Content.Value<string>("thirdTitle"); }
        }

        public string FourthTitle
        {
            get { return Content.Value<string>("fourthTitle"); }
        }

        public string FourthText
        {
            get { return Content.Value<string>("fourthText"); }
        }

        public string FifthTitle
        {
            get { return Content.Value<string>("fifthTitle"); }
        }

        public string FifthText
        {
            get { return Content.Value<string>("fifthText"); }
        }

        public string SixthTitle
        {
            get { return Content.Value<string>("sixthTitle"); }
        }

        public string SixthText
        {
            get { return Content.Value<string>("sixthText"); }
        }

        public string SeventhTitle
        {
            get { return Content.Value<string>("seventhTitle"); }
        }

        public string SeventhText
        {
            get { return Content.Value<string>("seventhText"); }
        }

        public string EightTitle
        {
            get { return Content.Value<string>("eightTitle"); }
        }

        public string EightText
        {
            get { return Content.Value<string>("eightText"); }
        }

        public string NinthTitle
        {
            get { return Content.Value<string>("ninthTitle"); }
        }

        public string NinthText
        {
            get { return Content.Value<string>("ninthText"); }
        }

        public string TenthTitle
        {
            get { return Content.Value<string>("tenthTitle"); }
        }

        public string TenthText
        {
            get { return Content.Value<string>("tenthText"); }
        }

        public AboutUs(IPublishedContent content) : base(content)
        {

        }
    }
}