using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorFront.Models;
using BlazorFront.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorFront.Pages
{
    public partial class EmployeePage
    {
        public IEnumerable<Employee> Employees { get; set; }

        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Employees = (await EmployeeService.GetEmployees()).ToList();

        }

        // public List<Employee> Employees { get; set; } = new List<Employee>();

        // [Inject]
        // public IEmployeeService EmployeeService { get; set; }

        // protected override async Task OnInitializedAsync()
        // {
        //     Employees = (await EmployeeService.GetEmployees()).ToList();
        // }
    }
}