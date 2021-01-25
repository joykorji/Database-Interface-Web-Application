using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Http;

namespace EmployeeManagement.ViewModels
{
    public class EmployeeCreateViewModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "Name can not exceed 50 characters.")]
        public string Name { get; set; }

        [Required]
       // [RegularExpression(@"^[a-zA-Z0-9_.+-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Invalid Email Format.")]
        [Display(Name = "Office Email")]
        public string Email { get; set; }

        //[Required] this variable is by default Required. 
        public Dept? Departement { get; set; }

        public IFormFile Photo { get; set; }
    }
}
