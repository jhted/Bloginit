using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MyFirstForm.Models
{
    public class ContactFormViewModel
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your email")]
        [EmailAddress(ErrorMessage = "Please check your email address, it ain't right")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your subject")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "Say Something!!")]
        [MaxLength(500, ErrorMessage = "Message too long, dont pass 500 charectors")]
        public string Message { get; set; }
        public int ContactFormId { get; set; }
    }
}