using ClientDependency.Core.Logging;
using MyFirstForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace MyFirstForm.Controllers
{
    public class ContactFormController : SurfaceController
    {
        [HttpPost]
        public ActionResult Submit(ContactFormViewModel model)
        {
            // if (!ModelState.IsValid)
            //    return CurrentUmbracoPage();
            bool success = false;
            if (ModelState.IsValid)
            {
                success = SendEmail(model);
            } else
            {
                return CurrentUmbracoPage();
            }
            /*
            var conatctPage = UmbracoContext.Content.GetById(false, model.ContactFormId);

            var successMessage = conatctPage.Value<IHtmlString>("succesMassage");
            var errorMessage = conatctPage.Value<IHtmlString>("errorMassage")*/

            var successMessage = "Success";
            var errorMessage = "Error";

            return PartialView("~/Views/Partials/Contact/results.cshtml", success ? successMessage : errorMessage);

            // Work with form data here

            // return RedirectToCurrentUmbracoPage();
        }
        // old controla

        [HttpGet]
        public ActionResult RenderForm()
        {
            ContactFormViewModel model = new ContactFormViewModel() { ContactFormId = CurrentPage.Id };
            return PartialView("~/Views/Partials/Contact/contactForm.cshtml", model);
        }

        [HttpPost]
        public ActionResult RenderForm(ContactFormViewModel model)
        {
            return PartialView("~/Views/Partials/Contact/contactForm.cshtml", model);
        }
        public bool SendEmail(ContactFormViewModel model)
        {
             
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
            catch ( ex)
            {
                return false;
            }
            /*
            return true;
             */
        }
    }
}