using System.Collections.Generic;
using System.Web.Mvc;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;
using WebsiteProject.Models;

namespace WebsiteProject.Controllers
{
    public class PersonGalleryController : RenderMvcController
    {
        [HttpGet]
        public ActionResult PersonGallery(ContentModel content)
        {
            var umbUsers = new List<UserModel>();
            var allUsers = Services.MemberService.GetAllMembers();
            var persons = new PersonGallery(content.Content);
            foreach (var item in allUsers)
            {
                

                var PrimeiroNome = item.GetValue<string>("primeironome");

                var avatarId = item.GetValue<int>("avatar");

                var avatar = UmbracoContext.MediaCache.GetById(avatarId);
                
                var umbUser = new UserModel();

                umbUser.Nome = PrimeiroNome;
                umbUser.Avatar = avatar;
                umbUser.ImagemUrl = avatar.Url;
                


                umbUsers.Add(umbUser);


            }
            persons.UmbUsers = umbUsers;

            return CurrentTemplate(persons);
        
        }
    }
}