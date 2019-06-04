using WebsiteProject.Models;
using System.Net.Mail;
using System.Web.Mvc;
using System.Web.Security;
using Umbraco.Web.Mvc;

namespace WebsiteProject.Controllers
{
    public class ForgotPasswordController : SurfaceController
    {
        public ActionResult ForgotPassword(ForgotPasswordModel forgotPasswordModel)
        {
            var member = Services.MemberService.GetByEmail(forgotPasswordModel.Email);

            if (member != null)
            {
                string email = member.Email;
                if (!string.IsNullOrEmpty(email))
                {
                    string password = Membership.GeneratePassword(8, 0);
                    Services.MemberService.SavePassword(member, password);

                    SmtpClient client = new SmtpClient();
                    var message = new MailMessage("teste20@teste.com", email)
                    {
                        Subject = "Nova Password",
                        Body = "A sua nova password é: " + password
                    };
                    client.Send(message);
                }
            }

            return PartialView();
        }
    }
}