using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Model
{
    public class GuestResponse
    {
        [Required(ErrorMessage ="please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "please enter your Email")]

        public string Email { get; set; }

        [Required(ErrorMessage = "please enter your phone")]
        public string phone { get; set; }

        [Required(ErrorMessage = "please enter your WillAttend")]
        public bool? WillAttend { get; set; }
    }
}
