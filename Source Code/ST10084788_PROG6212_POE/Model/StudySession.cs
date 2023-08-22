using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace ST10084788_PROG6212_POE.Model
{
    public class StudySession
    {
        // this class contains the attributes that are used in the StudySessions table in the database
        
        // StudyID -- auto-generated
        [Key]
        public int StudyId { get; set; }


        // module code
        [Display(Name = "Module Code")]
        public string ModuleCode { get; set; }


        // semester name
        [Display(Name = "Semester Name")]
        public string SemesterName { get; set; }


        // study date -- the date that the user has studied on
        [Display(Name = "Date Studied On")]
        [Required(ErrorMessage = "The Study Date Is A Mandatory Field")]
        public DateTime StudyDate { get; set; }

        // amount of hours studied
        [Display(Name = "Amount Of Hours Studied")]
        [Required(ErrorMessage = "The Hours Studied Is A Mandatory Field")]

        // the amount of hours studied must be between 1-100 hours
        [Range(1, 100, ErrorMessage = "The Hours Studied Must Be Between 1-100 Hours")]
        public int HoursStudied { get; set; }

        // calculated field that calculates the week in the semester in which the user studied
        [Display(Name = "Week Studied In Semester")]
        public int StudyWeek { get; set; }

        // username of current logged in user
        public string Username { get; set; }


    }
}
