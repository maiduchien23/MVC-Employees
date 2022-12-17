using System.ComponentModel.DataAnnotations;

namespace MvcEmployees.Models
{
    public class Employees
    {
            public int Id { get; set; }
            public string? EmployeeId { get; set; }
            [Display(Name = "Employee Name")]
            public string? EmployeeName { get; set; }
            [Display(Name = "Department")]
            public string? Department { get; set; }
            [Display(Name = "Salary")]
            public string? Salary { get; set; }
    }
}
