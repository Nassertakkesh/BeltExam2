using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace Exam2.Models
{

    public class User
    {
        [Key] // denotes PK, not needed if named ModelNameId
        public int UserId { get; set; }


        [RegularExpression(@"^[a-zA-Z]*$", ErrorMessage = "Only Characters")]
        [Required(ErrorMessage = "is required.")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }


        [RegularExpression(@"^[a-zA-Z]*$", ErrorMessage = "Only Characters")]

        [Required(ErrorMessage = "is required.")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "is required.")]
        [EmailAddress]
        public string Email { get; set; }

        [RegularExpression(@"^.*(?=.{3,18})(?=.*\d)(?=.*[A-Za-z])(?=.*[@%&#]{1,}).*$", ErrorMessage = "Password doesn't meet the requirements")]
        [Required(ErrorMessage = "is required.")]
        [MinLength(3, ErrorMessage = "must be at least 3 characters")]
        [DataType(DataType.Password)] // auto fills input type attr
        public string Password { get; set; }


        [NotMapped] // don't add to DB
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "doesn't match password")]
        [Display(Name = "Confirm Password")]
        public string PasswordConfirm { get; set; }


        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public List<Player> Attendees { get; set; }
        public List<Activity> Events {get;set;}

        public string FullName()
        {
            return FirstName + " " + LastName;
        }


    }
}