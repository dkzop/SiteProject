using System.Web.Mvc;
using System.Web.Security;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;
using WebsiteProject.Models;

namespace WebsiteProject.Controllers
{
    [Authorize]
    public class ProfileController : RenderMvcController
    {
        [HttpGet]
        public ActionResult ProfilePage(ContentModel content)
        {
            var membershipUser = Membership.GetUser();
            var user = Services.MemberService.GetById((int)membershipUser.ProviderUserKey);
            var returnModel = new ProfilePageModel(content.Content)
            {
                Person = new PersonModel()
                {
                    PrimeiroNome = user.GetValue<string>("primeironome"),
                    DatadeNascimento = user.GetValue<string>("datadenascimento"),
                    Peso = user.GetValue<int>("peso"),
                    Altura = user.GetValue<int>("altura"),
                    CordoCabelo = user.GetValue<string>("cordoCabelo"),
                    CordeOlhos = user.GetValue<string>("cordeOlhos"),
                }
            };

            var avatarId = user.GetValue<int>("avatar");

            var avatar = UmbracoContext.MediaCache.GetById(avatarId);

            if (avatar != null)
            {
                returnModel.Person.ImagemUrl = avatar.Url;
            }
            else
            {
                return CurrentTemplate(returnModel);
            }

            return CurrentTemplate(returnModel);
        }
    }
}