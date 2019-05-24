using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.Models;

namespace WebsiteProject.Models
{
    public class ProfilePageModel : ContentModel
    {

        public ProfilePageModel(IPublishedContent content) : base(content)
        { }

        public PersonModel Person { get; set; }
    }
}