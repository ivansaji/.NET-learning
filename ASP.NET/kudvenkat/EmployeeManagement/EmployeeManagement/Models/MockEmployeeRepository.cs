using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            // basic data stored as _employeeList
            _employeeList = new List<Employee>()
            {
                new Employee() {Id=1, Name="Ivin", Email="ivin@gmail.com", Department="HR"},
                new Employee() {Id=2, Name="Ivan", Email="ivan@gmail.com", Department="IT"},
                new Employee() {Id=3, Name="Jomy", Email="jomy@gmail.com", Department="IT"},
            };
        }

        public Employee Add(Employee employee)
        {
            //Increasing ID property of employee
            employee.Id = _employeeList.Max(e => e.Id) + 1;
            //Adding the employee details
            _employeeList.Add(employee);
            return employee;
        }

        public Employee Delete(int id)
        {
           Employee employee = _employeeList.FirstOrDefault(e => e.Id == id);
            if(employee != null)
            {
                _employeeList.Remove(employee);
            }
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int Id)

        {
            //the call from Iemployee reaches here and fetches data and returns reqd data
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }

        public Employee Update(Employee employeeChanges)
        {
            Employee employee = _employeeList.FirstOrDefault(e => e.Id == employeeChanges.Id);
            if (employee != null)
            {
                employee.Name = employeeChanges.Name;
                employee.Email = employeeChanges.Email;
                employee.Department = employeeChanges.Department;
            }
            return employee;
        }
    }
}
