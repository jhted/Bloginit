using System;
using System.Net.Mail;
using System.Web;
using Umbraco.Web.Mvc;
using System.Web.Mvc;
using Blogini.Core.ViewModels;
using Umbraco.Web;
using Umbraco.Core.Logging;

namespace Blogini.Core.Controller
{
    public class ContactSurfaceController : SurfaceController
    {
        private readonly ILogger _logger;
        public ContactSurfaceController(ILogger logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult RenderForm()
        {
            ContactViewModel model = new ContactViewModel() { ContactFormId = CurrentPage.Id };
            return PartialView("~/Views/Partials/Contact/contactForm.cshtml", model);
        }

        [HttpPost]
        public ActionResult RenderForm(ContactViewModel model)
        {
            return PartialView("~/Views/Partials/Contact/contactForm.cshtml", model);
        }
        public ActionResult SubmitForm(ContactViewModel model)
        {
            bool success = false;
            if (ModelState.IsValid)
            {
                success = SendEmail(model);
            }
            /*
            var conatctPage = UmbracoContext.Content.GetById(false, model.ContactFormId);

            var successMessage = conatctPage.Value<IHtmlString>("succesMassage");
            var errorMessage = conatctPage.Value<IHtmlString>("errorMassage")*/

            var successMessage = "Success";
            var errorMessage = "Error";

            return PartialView("~/Views/Partials/Contact/results.cshtml", success ? successMessage : errorMessage);
        }
        public bool SendEmail(ContactViewModel model)
        {
            /*
             
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient client = new SmtpClient();

                string toAddress = "to@test.com";
                string fromAddress = "from@test.com";
                message.Subject = $"Enquiry from: {model.Name} - {model.Email}";
                message.Body = model.Message;
                message.To.Add(new MailAddress(toAddress, toAddress));
                message.From = new MailAddress(fromAddress, fromAddress);

                client.Send(message);
                return true;

            }
            catch (Exception ex)
            {
                _logger.Error(typeof(ContactSurfaceController), ex, "Error sending Form");
                return false;
            }
             */
            return true;
        }
    }
}
