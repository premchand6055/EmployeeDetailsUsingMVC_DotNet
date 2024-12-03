using System.ComponentModel.DataAnnotations;

namespace EmployeeDetails.Models
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Designation { get; set; } = string.Empty ;
        [Required]
        public DateTime DateOfJoin { get; set; }
        [Required]
        public decimal Salary { get; set; }
        [Required]
        public char Gender { get; set; }
        [Required]
        public string State { get; set; } = string.Empty;
    }
}
