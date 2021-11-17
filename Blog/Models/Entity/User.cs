using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models.Entity
{
    [Table("Users")]
    public class User
    {
        public User()
        {

        }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public User(int id, string username, string password)
        {
            Id = id;
            Username = username;
            Password = password;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
