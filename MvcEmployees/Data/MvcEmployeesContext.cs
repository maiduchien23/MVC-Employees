using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcEmployees.Models;

namespace MvcEmployees.Data
{
    public class MvcEmployeesContext : DbContext
    {
        public MvcEmployeesContext (DbContextOptions<MvcEmployeesContext> options)
            : base(options)
        {
        }

        public DbSet<MvcEmployees.Models.Employees> Employees { get; set; } = default!;
    }
}
