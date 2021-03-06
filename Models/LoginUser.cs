using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginRegC_.Models
{
    public class LoginUser
    {
        [Required]
        [EmailAddress]
        public string LoginEmail {get; set;}
        [Required]
        [DataType(DataType.Password)]
        public string LoginPassword {get; set;}
    }
}