using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exam2.Models
{

    public class Player
    {
////////////////////////////////////////////////////
        [Key] // denotes PK, not needed if named ModelNameId
        public int PlayerId { get; set; }
        public int ActivityId { get; set; }
        public int UserId { get; set; }
        public User Attendees { get; set; }
        public Activity Event { get; set; }

    }
}