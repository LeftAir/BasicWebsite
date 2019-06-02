using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BasicWebsite.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required(ErrorMessage = "You must fill up this field")]
        [Range(5, 20, ErrorMessage = "Please enter a username with a length between 5 and 20.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "You must fill up this field")]
        [Range(8, 20, ErrorMessage = "Please enter a password with a length between 8 and 20.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "You must fill up this field")]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}