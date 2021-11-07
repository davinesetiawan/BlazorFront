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
        public string id { get; set; }

        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        public Employee Employee { get; set; } = new Employee();

        protected override async Task OnInitializedAsync()
        {
            id = id ?? "9";
            Employee = await EmployeeService.GetEmployee(int.Parse(id));
        }
    }
}