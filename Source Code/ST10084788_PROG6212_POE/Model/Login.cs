using System.ComponentModel.DataAnnotations;

namespace ST10084788_PROG6212_POE.Model
{
    public class Login
    {
        // this class contains the variables used when the user logs into the website
        
        // username
        [Required]
        public string Username { get; set; }
        
        //Password
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
