using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.Models;

namespace WebsiteProject.Models
{
    public class PersonGallery : ContentModel
    {
        public PersonGallery(IPublishedContent content) : base(content)
        {
        }

        public List<UserModel> UmbUsers  { get; set; }

        public PersonModel Person { get; set; }



    }
}