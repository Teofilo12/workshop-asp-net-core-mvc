using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;
using System.Collections.Generic;

namespace SalesWebMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> listDepartments = new List<Department>();
            listDepartments.Add(new Department { Id = 1, Name = "Eletronics" });
            listDepartments.Add(new Department { Id = 2, Name = "Fashion" });

            return View(listDepartments);
        }
    }
}