using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Task.Models
{
    public class User
    {   public int Id { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 6)]
        public string Fname { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 6)]
        public string Lname { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 6)]

        [Required]
        [StringLength(20, MinimumLength = 6)]
        public string Username { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
      
    }
}