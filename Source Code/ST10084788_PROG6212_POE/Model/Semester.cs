using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.EntityFrameworkCore;

namespace ST10084788_PROG6212_POE.Model
{
    
    public class Semester
    {
        // this class contains the attributes that are used in the Semesters table in the database 
        
        // SemesterID -- auto-generated
        [Key]
        public int SemesterID { get; set; }


        // semester name
        [Display(Name = "Semester Name")]
        [Required(ErrorMessage = "The Semester Name Is A Mandatory Field")]

        // the max length of the semester name is 50 characters
        [MaxLength(50, ErrorMessage = "The Semester Name Cannot Have More Than 50 Characters")]

        // the min length of the semester name is 3 characters
        [MinLength(3, ErrorMessage = "The Semester Name Must Have At Least 3 Characters")]
        public string SemesterName { get; set; }

        
        // semester weeks -- number of weeks in the semester
        [Display(Name = "Amount Of Weeks In Semester")]
        [Required(ErrorMessage = "The Semester Weeks Is A Mandatory Field")]

        // the number of weeks within the semester must be between 1-50
        [Range(1,50, ErrorMessage = "The Semester Weeks Must Be Between 1-50 Weeks")]
        public int SemesterWeeks { get; set; }

        
        // semester date -- the starting date of the semester
        [Display(Name = "Semester Start Date")]
        [Required(ErrorMessage = "The Semester Start Date Is A Mandatory Field")]
        public DateTime SemesterDate { get; set; }


        // username of current logged in user
        public string Username { get; set; }
    }
}
