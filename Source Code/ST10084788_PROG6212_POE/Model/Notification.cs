using System.ComponentModel.DataAnnotations;

namespace ST10084788_PROG6212_POE.Model
{
    public class Notification
    {
        // this class holds the attributes that are found in the Notifications table in the database

        // NotificationID -- auto-generated
        [Key]
        public int NotificationID { get; set; }

        // module code
        [Display(Name = "Module Code")]
        [Required(ErrorMessage = "The Module Code Is A Mandatory Field")]
        public string NotifyModuleCode { get; set; }

        // day of the week (Monday, Tuesday, etc.)
        [Display(Name = "Day Of The Week")]
        [Required(ErrorMessage = "The Day Of The Week Is A Mandatory Field")]
        public string DayOfTheWeek { get; set; }

        // username of current logged in user
        public string Username { get; set; }
    }
}
