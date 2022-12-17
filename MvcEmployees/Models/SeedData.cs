using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcEmployees.Data;
using System;
using System.Linq;



namespace MvcEmployees.Models;

    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcEmployeesContext(
                serviceProvider.GetRequiredService<
                DbContextOptions<MvcEmployeesContext>>()))
            {
                if (context.Employees.Any())
                {
                    return;   // DB has been seeded
                }
                context.Employees.AddRange(
                    new Employees
                    {
                        EmployeeId = "EM001",
                        EmployeeName = "Jonh Carter",
                        Department = "HR",
                        Salary = "3000"
                    },
                    new Employees
                    {
                        EmployeeId = "EM002",
                        EmployeeName = "Michael Bean",
                        Department = "SC",
                        Salary = "1300"
                    },
                    new Employees
                    {
                        EmployeeId = "EM003",
                        EmployeeName = "Jimmy Floy",
                        Department = "MD",
                        Salary = "2000"
                    },
                    new Employees
                    {
                        EmployeeId = "EM004",
                        EmployeeName = "Mary Brown",
                        Department = "MD",
                        Salary = "2000"
                    }
                    );
                context.SaveChanges();
            
                }
        }
}
