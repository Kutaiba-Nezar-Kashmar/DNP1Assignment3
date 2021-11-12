using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FamilyDataServer.Models
{
    public class User
    {
        [Key]
        public string UserName { get; set; }
        [Required]
        [PasswordPropertyText]
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        [EmailAddress]
        public string EmailAddress { get; set; }
    }
}