using System.ComponentModel.DataAnnotations;

namespace ST10084788_PROG6212_POE.Model
{
    public class Register
    {
        // this class holds the attributes that the user will use when they register for an account on the website

        // desired username
        [Required(ErrorMessage = "Username Is Required.")]
        public string Username { get; set; }

        
        // password
        [Required(ErrorMessage = "Password Is Required.")]
        
        // the password must be between 6-18 characters in length
        [StringLength(18, ErrorMessage = "The Password Must Be Between 6-18 Characters Long.", MinimumLength = 6)]
        
        // the password must have at least one uppercase letter, one lowercase letter, and one special character
        [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        // confirmed password -- must match the Password field
        [Required(ErrorMessage = "Confirmation Password Is Required.")]
        [DataType(DataType.Password)]

        // if the confirmed password is the exact same as the password that was entered,
        // the user will then be able to create an account
        [Compare(nameof(Password), ErrorMessage = "Error! The Password And Confirmation Password Do Not Match.")]
        public string ConfirmPassword { get; set; }
    }
}
