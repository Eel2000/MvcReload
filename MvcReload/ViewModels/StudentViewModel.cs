using MvcReload.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace MvcReload.ViewModels
{
    public class StudentViewModel
    {
        [Required]
        [Display(Name ="Prenom")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name ="Nom")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name ="Numero Telephone")]
        public string Phone { get; set; }

        [Required]
        [Display(Name ="Promotion")]
        public Grade? Grade { get; set; }
    }
}
