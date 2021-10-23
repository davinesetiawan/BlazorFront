using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorFront.Models;
using BlazorFront.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorFront.Pages
{
    public partial class DepartmentPage
    {
        public List<Department> Departments { get; set; } = new List<Department>();

        [Inject]
        public IDepartmentService DepartmentService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Departments = (await DepartmentService.GetAll()).ToList();
        }
    }
}