using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public static class InitialSeed
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee() { Id = 1, Name = "Mary", Department = Departments.Finance, Email = "mary@blackbird.sa" },
                new Employee() { Id = 2, Name = "John", Department = Departments.HR, Email = "John@blackbird.sa" },
                new Employee() { Id = 3, Name = "Sam", Department = Departments.IT, Email = "sam@blackbird.sa" }
            );
        }
    }
}
