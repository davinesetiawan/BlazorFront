using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorFront.Models
{
    public class Employee
    {
        public int employeeId { get; set; }

        [Required(ErrorMessage ="First Name is Required")]
        [StringLength(100,MinimumLength =2)]
        public string firstName { get; set; }

        [Required(ErrorMessage ="Last Name is Required")]
        [StringLength(100,MinimumLength =2)]
        public string lastName { get; set; }

        [Required]
        public string email { get; set; }

        public DateTime dateofBirth { get; set; }

        public Gender Gender { get; set; }

        public Department Department {get; set;}
        
        public int departmentId { get; set; }

        public Department departmentName { get; set; }

        public string photoPath { get; set; }

    }
    
    public enum Gender {
        Male,Female
        }
}