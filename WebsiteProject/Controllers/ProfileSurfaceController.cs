using System;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Umbraco.Core;
using Umbraco.Web.Mvc;
using WebsiteProject.Models;


namespace WebsiteProject.Controllers
{
    public class ProfileSurfaceController : SurfaceController
    {

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ChangeUsername(ChangeUsernameModel changeUsernameModel)
        {

            ViewBag.changeUsernameModel = changeUsernameModel;
            if (User.Identity.IsAuthenticated && ModelState.IsValid)
            {
                var membershipUser = Membership.GetUser();
                var user = Services.MemberService.GetById((int)membershipUser.ProviderUserKey);
                var allUsernames = Services.MemberService.GetByUsername(changeUsernameModel.NewUsername);
                if ((changeUsernameModel.NewUsername == changeUsernameModel.ConfirmNewUsername) && (allUsernames == null))
                {
                    user.Username = changeUsernameModel.NewUsername;
                    
                    Services.MemberService.Save(user);
                    FormsAuthentication.SetAuthCookie(changeUsernameModel.ConfirmNewUsername, false);

                    TempData["Success"] = "Username successfully changed.";

                    return RedirectToCurrentUmbracoPage();
                }
                else
                {
                    TempData["Error"] = "Error changing username. Username already exists or New and Confirm Username aren't the same.";
                    return RedirectToCurrentUmbracoPage();
                }
            }

            return RedirectToCurrentUmbracoPage();
        }

        // Change Password //

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ChangePassword(ChangePasswordModel changePasswordModel)
        {
            if (User.Identity.IsAuthenticated && ModelState.IsValid)
            {
                var user = Membership.GetUser();
                var password = user.GetPassword();
                if ((changePasswordModel.Password != changePasswordModel.NewPassword) && (password == changePasswordModel.Password))
                {
                    user.ChangePassword(changePasswordModel.Password, changePasswordModel.NewPassword);
                    TempData["Success"] = "Password alterado com sucesso! ";
                    return RedirectToCurrentUmbracoPage();
                }
                else
                {
                    TempData["Error"] = "Password não alterada! ";
                }
            }
            return RedirectToCurrentUmbracoPage();
        }

        public ActionResult PersonData(PersonModel personModel)
        {
            if (User.Identity.IsAuthenticated && ModelState.IsValid)
            {
                var membershipUser = Membership.GetUser();
                var user = Services.MemberService.GetById((int)membershipUser.ProviderUserKey);
                user.SetValue("primeiroNome", personModel.PrimeiroNome);
                user.SetValue("datadenascimento", personModel.DatadeNascimento);
                user.SetValue("peso", personModel.Peso);
                user.SetValue("altura", personModel.Altura);
                user.SetValue("cordoCabelo", personModel.CordoCabelo);
                user.SetValue("cordeOlhos", personModel.CordeOlhos);
                user.SetValue("sexo", personModel.SexoPessoa);
                if (personModel.ImagemParaCarregar != null)
                {
                    var newFileReference = Services.MediaService.CreateMediaWithIdentity(personModel.PrimeiroNome, -1, "Image");
                    if (!Valid(personModel.ImagemParaCarregar))
                    {
                        
                        newFileReference.SetValue(Services.ContentTypeBaseServices, "umbracoFile", personModel.ImagemParaCarregar.FileName, personModel.ImagemParaCarregar.InputStream);
                        Services.MediaService.Save(newFileReference);

                        user.SetValue("avatar", newFileReference.Id);
                    }

                    else
                    {
                        TempData["Error"] = "Image file extension invalid. Can only upload PNG, JPG and JPEG files.";
                        return RedirectToCurrentUmbracoPage();
                    }
                }

                Services.MemberService.Save(user);
                
            }
            TempData["Success"] = "Profile details saved.";


            return RedirectToCurrentUmbracoPage();
        }

        private bool Valid(HttpPostedFileBase imagem)
        {
            var fileInfo = new FileInfo(imagem.FileName);
            if ((new string[] { "png", "jpg", "jpeg" }).Contains(fileInfo.Extension)
                && imagem.ContentLength < 15000)
            {
                return true;
            }

            return false;
        }
    }
}
