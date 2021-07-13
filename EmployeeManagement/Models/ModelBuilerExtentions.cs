using System;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Models
{
    public static class ModelBuilerExtentions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(

                new Employee
                {
                    Id = 1,
                    Name = "Mackey",
                    Department = Dept.Law,
                    Email = "Mackey@pragimtech.com"
                },
                new Employee
                {
                    Id = 2,
                    Name = "PC Principle",
                    Department = Dept.Sociology,
                    Email = "Principle@pragimtech.com"
                }

                );
        }
    }
}
