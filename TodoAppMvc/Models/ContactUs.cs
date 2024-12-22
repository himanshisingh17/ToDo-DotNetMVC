using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TodoAppMvc.Models
{
    public class ContactUs
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please Enter Your Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter Your Valid Email")]
        public string Email  { get; set; }
        [Required(ErrorMessage = "Please Enter Your Message")]
        public string Message { get; set; }
    }
}
