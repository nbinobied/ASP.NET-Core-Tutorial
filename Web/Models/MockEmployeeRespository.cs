using System;
using System.Collections.Generic;
using System.Linq;

namespace Web.Models
{
    public class MockEmployeeRespository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRespository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Mary", Department = Departments.Finance, Email = "mary@blackbird.sa"},
                new Employee() { Id = 2, Name = "John", Department = Departments.HR, Email = "John@blackbird.sa"},
                new Employee() { Id = 3, Name = "Sam", Department = Departments.IT, Email = "sam@blackbird.sa"}
            };
        }

        public Employee Add(Employee employee)
        {
            employee.Id = _employeeList.Max(e => e.Id) + 1;
            _employeeList.Add(employee);
            return employee;
        }

        public Employee Delete(int id)
        {
            Employee employee = _employeeList.FirstOrDefault(e => e.Id == id);
            if (employee != null)
            {
                _employeeList.Remove(employee);
            }
            return employee;
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.Find(e => e.Id == id);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _employeeList;
        }

        public Employee Update(Employee employee)
        {
            Employee ModifiedEmployee = _employeeList.FirstOrDefault(e => e.Id == employee.Id);
            if (ModifiedEmployee != null)
            {
                ModifiedEmployee.Name = employee.Name;
                ModifiedEmployee.Email = employee.Email;
                ModifiedEmployee.Department = employee.Department;
            }
            return ModifiedEmployee;
        }
    }
}
