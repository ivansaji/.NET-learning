﻿using EmployeeManagement.Models;
using EmployeeManagement.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepository _employeeRepository;

        //homecontroller creates an instance of IEmployeeRepository as parameter where a call is done to Iemploy....
        //Rest in IEmployee
        public HomeController(IEmployeeRepository employeeRepository)
        {
            
            _employeeRepository = employeeRepository; 
        }
        public string Index()
        {
            //change Id in GetEmployee(id) to get reqd data
            return _employeeRepository.GetEmployee(1).Name;
        }
        public ViewResult Details()
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Employee = _employeeRepository.GetEmployee(2),
                PageTitle = "Employee Details"
            };
            return View(homeDetailsViewModel);
        }
    }
}
