
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
        public string HomeTitle
        {
            get { return Content.Value<string>("homeTitle"); }
        }

        public string HomeTopButton
        {
            get { return Content.Value<string>("homeTopButtom"); }
        }

        public string TitleLeft
        {
            get { return Content.Value<string>("titleLeft"); }
        }

        public string Sub_TitleLeft
        {
            get { return Content.Value<string>("sub_titleLeft"); }
        }

        public string TextLeft
        {
            get { return Content.Value<string>("textLeft"); }
        }

        public string LeftButton
        {
            get { return Content.Value<string>("leftButton"); }
        }

        public string TitleRight
        {
            get { return Content.Value<string>("titleRight"); }
        }

        public string Sub_TitleRight
        {
            get { return Content.Value<string>("sub_titleRight"); }
        }

        public string TextRight
        {
            get { return Content.Value<string>("textRight"); }
        }

        public string RightButton
        {
            get { return Content.Value<string>("rightButton"); }
        }

        public string SliderTitle
        {
            get { return Content.Value<string>("sliderTitle"); }
        }

        public string Slider_subTitle
        {
            get { return Content.Value<string>("slider_subTitle"); }
        }

        public string SliderText_1
        {
            get { return Content.Value<string>("sliderText_1"); }
        }

        public string Sliderauthor_1
        {
            get { return Content.Value<string>("sliderauthor_1"); }
        }

        public string Slidertext_2
        {
            get { return Content.Value<string>("slidertext_2"); }
        }

        public string Sliderauthor_2
        {
            get { return Content.Value<string>("sliderauthor_2"); }
        }

        public string Slidertext_3
        {
            get { return Content.Value<string>("slidertext_3"); }
        }

        public string Sliderauthor_3
        {
            get { return Content.Value<string>("sliderauthor_3"); }
        }


        public MvcHtmlString LearnMoreLeft
        {
            get { return Content.Value<MvcHtmlString>("learnMoreLeft"); }
        }

        public MvcHtmlString LearnMoreRight
        {
            get { return Content.Value<MvcHtmlString>("learnMoreLeft"); }
        }

        public MvcHtmlString BottomLeft
        {
            get { return Content.Value<MvcHtmlString>("bottomLeft"); }
        }

        public MvcHtmlString BottomCenter
        {
            get { return Content.Value<MvcHtmlString>("bottomCenter"); }
        }

        public MvcHtmlString BottomRight
        {
            get { return Content.Value<MvcHtmlString>("bottomRight"); }
        }




        public Home(IPublishedContent content) : base(content)
        {

        }


    }
}