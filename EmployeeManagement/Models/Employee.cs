using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class Employee
    {

        public int Id { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "Name can not exceed 50 characters.")]
        public string Name { get; set; }

        [Required]
        //[RegularExpression(@"^[a-zA-Z0-9_.+-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Invalid Email Format.")]
        [Display(Name = "Office Email")]
        public string Email { get; set; }

        //[Required] this variable is by default Required. 
        public Dept? Departement { get; set; }

        public string PhotoPath { get; set; }

    }
}
