using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SchoolWebEFNimaV2.Models
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }
        [Required]
        public string CourseName { get; set; }
        [Required]
        public System.DateTime StartDate { get; set; }
        [Required]
        public System.DateTime EndDate { get; set; }

        public int? TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        public List<Assignment> Assignments { get; set; }
        public List<Student> Students { get; set; }
    }
}