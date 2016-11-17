using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SchoolWebEFNimaV2.Models
{
    public class Assignment
    {
        [Key]
        public int AssignmentID { get; set; }
        [Required]
        public string AssignmentName { get; set; }
        [Required]
        public System.DateTime UploadDate { get; set; }
        [Required]
        public System.DateTime DeadlineDate { get; set; }

        public int? CourseId { get; set; }
        public Course RelatedCourse { get; set; }

        public int? TeacherId { get; set; }
        public Teacher RelatedTeacher { get; set; }

    }
}
