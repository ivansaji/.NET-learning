using EmployeeManagement.Models;
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
        private readonly IEmployeeRepository _employeeRepository;

        //homecontroller creates an instance of IEmployeeRepository as parameter where a call is done to Iemploy....
        //Rest in IEmployee
        public HomeController(IEmployeeRepository employeeRepository)
        {
            
            _employeeRepository = employeeRepository; 
        }

        //attribute route

        public ViewResult Index()
        {
            //change Id in GetEmployee(id) to get reqd data
            var model = _employeeRepository.GetAllEmployee();
            return View(model);
        }

        //attribute route

         public ViewResult Details(int Id)
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Employee = _employeeRepository.GetEmployee(Id),
                PageTitle = "Employee Details"
            };
            return View(homeDetailsViewModel);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                Employee newEmployee = _employeeRepository.Add(employee);
                return RedirectToAction("details", new { id = newEmployee.Id });
            }
            return View();
        }
    }
}
