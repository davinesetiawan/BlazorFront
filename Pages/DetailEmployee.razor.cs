using System.Reflection.Metadata;
using System.Threading.Tasks;
using BlazorFront.Models;
using BlazorFront.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorFront.Pages
{
    public partial class DetailEmployee
    {
        [Parameter]
        public string employId { get; set; }
        public string id { get; set; }

        public IEmployeeService EmployeeService { get; set; }
        public IDepartmentService DepartmentService { get; set; }

        public Employee Employee { get; set; } = new Employee();
        public Department Department { get; set; } = new Department();

        protected override async Task OnInitializedAsync()
        {
            employId = employId ?? "1";
            Employee = await EmployeeService.GetById(int.Parse(employId));
            id = id ?? "1";
            Department = await DepartmentService.GetById(int.Parse(id));
        }
    }
}