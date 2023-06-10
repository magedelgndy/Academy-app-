using System.ComponentModel.DataAnnotations;

namespace MVCDay2.Models
{
    public class Account
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Please enter a password")]
        [RegularExpression(@"[A-Za-z\\d@$!%*#?&]{8,16}$", 
             ErrorMessage = "Password must be between 8 and 16 characters long and contain at least one digit," +
            "\n one lowercase letter," +
            "\n one uppercase letter," +
            "\n one special character," +
            "\n and no whitespace.")]
        public string Password { get; set; }
    }
}
