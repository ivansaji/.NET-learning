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
        private IEmployeeRepository _employeeRepository;

        //homecontroller creates an instance of IEmployeeRepository as parameter where a call is done to Iemploy....
        //Rest in IEmployee
        public HomeController(IEmployeeRepository employeeRepository)
        {
            
            _employeeRepository = employeeRepository; 
        }

        //attribute route
        [Route("Home")]
        [Route("Home/Index")]
        [Route("")]
        public ViewResult Index()
        {
            //change Id in GetEmployee(id) to get reqd data
            var model = _employeeRepository.GetAllEmployee();
            return View(model);
        }

        //attribute route
        [Route("Home/Details/{Id ?}")]
         public ViewResult Details(int Id)
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Employee = _employeeRepository.GetEmployee(Id),
                PageTitle = "Employee Details"
            };
            return View(homeDetailsViewModel);
        }
    }
}
