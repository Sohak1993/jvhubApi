using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.General
{
    [Table("Users")]
    public class User
    {
        public int Id { get; set; }

        [Required, StringLength(maximumLength: 20, MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required, StringLength(maximumLength: 20, MinimumLength = 2)]
        public string LastName { get; set; }

        [EmailAddress, Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
