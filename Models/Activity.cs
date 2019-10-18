using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace Exam2.Models
{

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
public class DateInTheFutureAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext context)
    {
        var futureDate = value as DateTime?;
        var memberNames = new List<string>() { context.MemberName };

        if (futureDate != null)
        {
            if (futureDate.Value.Date < DateTime.UtcNow.Date)
            {
                return new ValidationResult("This must be a date in the future", memberNames);
            }
        }

        return ValidationResult.Success;
    }
}
    public class Activity
    {
        [Key] // denotes PK, not needed if named ModelNameId
        public int ActivityId { get; set; }


        [Required(ErrorMessage = "is required.")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters")]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "is required.")]
        [DateInTheFuture]
        public DateTime ActivityDate { get; set; }

        [Required(ErrorMessage = "is required.")]
        public int Duration { get; set; }

        [Required(ErrorMessage = "is required.")]
        public string TimeSpan { get; set; }

        [Required(ErrorMessage = "is required.")]
        [MinLength(10, ErrorMessage = "must be at least 10 characters")]
        public string Description { get; set; }

        public User Creator {get;set;}
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public List<Player> Attendees { get; set; }
        // public List<Wedding> CreatedWedding {get;set;}


    }
}