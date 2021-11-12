using System.Reflection.Metadata;
using System.Threading.Tasks;
using BlazorFront.Models;
using BlazorFront.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace BlazorFront.Pages
{
    public partial class DetailEmployee
    {
        [Parameter]
        public string id { get; set; }

        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        public Employee Employee { get; set; } = new Employee();

        public string Coordinates { get; set; }

        public string ButtonText { get; set; } = "Hide Footer";
        public string CssClass { get; set; } = null;

        protected void Button_Click(){
            if(ButtonText == "Hide Footter"){
                ButtonText = "Show Footer";
                CssClass = "HideFooter";
            }else{
                CssClass = null;
                ButtonText = "Hide Footer";
            }
        }

        protected void Mouse_Move(MouseEventArgs e){
            Coordinates = $"X = {e.ClientX}, Y = {e.ClientY}";
        }

        protected override async Task OnInitializedAsync()
        {
            id = id ?? "9";
            Employee = await EmployeeService.GetEmployee(int.Parse(id));
        }
    }
}