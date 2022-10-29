using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.tweetapp.Model
{
    public class UserDetails
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string Gender { get; set; }
        public string Dob { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        public bool IsloggedIn { get; set; }
    }
}
