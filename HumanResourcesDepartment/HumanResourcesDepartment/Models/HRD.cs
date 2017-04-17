using System;
using System.Data.Entity;

namespace HumanResourcesDepartment.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
    }

    public class EmployeeDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}