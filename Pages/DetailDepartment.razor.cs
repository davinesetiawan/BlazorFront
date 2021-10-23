using System.Reflection.Metadata;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorFront.Models;
using BlazorFront.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorFront.Pages
{
    public partial class DetailDepartment
    {
        [Parameter]
        public string id { get; set; }

        [Inject]
        public IDepartmentService DepartmentService { get; set; }

        public Department Department { get; set; } = new Department();

        protected override async Task OnInitializedAsync()
        {
            id = id ?? "1";
            Department = await DepartmentService.GetById(int.Parse(id));
        }
    }
}