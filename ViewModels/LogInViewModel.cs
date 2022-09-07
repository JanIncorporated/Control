using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Control.ViewModels
{
    public class LogInViewModel
    {
        [Required(ErrorMessage = "Insert Email!")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Insert Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
