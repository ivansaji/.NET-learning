using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public interface IEmployeeRepository
    {
        //On instancce creation... from home controller it calls GetEmployee fuction in mock employee
        Employee GetEmployee(int Id);
        IEnumerable<Employee> GetAllEmployee();

        Employee Add(Employee employee);
    }
}
