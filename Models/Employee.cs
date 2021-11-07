using System;

namespace BlazorFront.Models
{
    public class Employee
    {
        public int employeeId { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string email { get; set; }

        public DateTime dateofBirth { get; set; }

        public Gender gender { get; set; }

        public Department Department {get; set;}
        
        public int departmentId { get; set; }

        public string departmentName { get; set; }

        public string photoPath { get; set; }

    }
    
    public enum Gender {
        Male,Female
        }
}