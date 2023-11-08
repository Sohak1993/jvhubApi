using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.ViewModels
{
    public class UserViewModel
    {
        [Required, StringLength(maximumLength: 20, MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required, StringLength(maximumLength: 20, MinimumLength = 2)]
        public string LastName { get; set; }

        [EmailAddress, Required]
        public string Email { get; set; }
    }
}
