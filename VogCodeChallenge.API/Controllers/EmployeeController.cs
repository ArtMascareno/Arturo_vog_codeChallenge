using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserInterface.Services;
using Vog.Domain.Entities;

namespace VogCodeChallenge.API.Controllers
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeService _employeeService = new EmployeeService();

        [HttpGet()]
        public async Task<List<Employee>> GetEmployees()
        {
            return _employeeService.ListAll().ToList();
        }
        
        [HttpGet("department/{departmentId}")]
        public async Task<List<Employee>> GetEmployeesByDepartment(int departmentId)
        {
            return _employeeService.ListAllByDepartment(departmentId).ToList();
        }
    }
}
