using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ST10084788_PROG6212_POE.Model
{
    public class Module
    {

        // this class holds the attributes that are found in the Modules table in the database

        // ModuleID -- auto-generated
        [Key]
        public int ModuleID { get; set; }

        
        // module code
        [Display(Name = "Module Code")]
        [Required(ErrorMessage = "The Module Code Is A Mandatory Field")]

        // the max length of the module code is 50 characters
        [MaxLength(50, ErrorMessage = "The Module Code Cannot Have More Than 50 Characters")]
        
        // the minimum length of the module code is 3 characters
        [MinLength(3, ErrorMessage = "The Module Code Must Have At Least 3 Characters")]
        public string ModuleCode { get; set; }
        

        // module name
        [Display(Name = "Module Name")]
        [Required(ErrorMessage = "The Module Name Is A Mandatory Field")]

        // the max length of the module name is 50 characters
        [MaxLength(50, ErrorMessage = "The Module Name Cannot Have More Than 50 Characters")]

        // the minimum length of the module name is 3 characters
        [MinLength(3, ErrorMessage = "The Module Name Must Have At Least 3 Characters")]
        public string ModuleName { get; set; }


        // module credits
        [Display(Name = "Module Credits")]
        [Required(ErrorMessage = "The Module Credits Is A Mandatory Field")]

        // the number of credits must be between 1-50
        [Range(1, 50, ErrorMessage = "The Module Credits Must Be Between 1-50 Credits")]
        public int ModuleCredits { get; set; }


        // amount of classes that the user has for the module in a week
        [Display(Name = "Class Hours Per A Week")]
        [Required(ErrorMessage = "The Class Hours Per Week Is A Mandatory Field")]

        // the number of class hours must be between 1-50
        [Range(1, 70, ErrorMessage = "The Class Hours Must Be Between 1-70 Hours")]
        public int ClassHoursPerWeek { get; set; }


        // calculated amount of self-study hours
        [Display(Name = "Required Self-Study Hours For The Week")]
        public int NeededHoursToStudy { get; set; }

        
        // name of semester
        [Display(Name = "Semester Name")]
        public string SemesterName { get; set; }


        // username of current logged in user
        public string Username { get; set; }
    }
}
