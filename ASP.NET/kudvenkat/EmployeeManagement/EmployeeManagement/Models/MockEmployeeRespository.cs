using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRespository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRespository()
        {
            _employeeList - new List<Employee>()
            {
                new Employee() {Id = 1, Name = "Mary" , Department = "HR", Email = "mary@gmail.com"};
                new Employee() {Id = 1, Name = "Jane", Department = "IT", Email = "jane@gmail.com" };
                new Employee() { Id = 1, Name = "Ivin", Department = "IT", Email = "ivin@gmail.com" };
        }
        }

        public Employee GetEmployee(int id)
        {
            throw new NotImplementedException();
        }
    }
}
