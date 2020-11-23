﻿using System;
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
                new Employee() {Id=3, Name="Jomy", Email="jomy@gmail.com", Department="IT"}
            };
        }
        public Employee GetEmployee(int Id)

        {
            //the call from Iemployee reaches here and fetches data and returns reqd data
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }
    }
}