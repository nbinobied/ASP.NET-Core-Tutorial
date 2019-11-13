using System.Collections.Generic;

namespace Web.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int id);
        IEnumerable<Employee> GetEmployees();
        Employee Add(Employee employee);
    }
}
