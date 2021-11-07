using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorFront.Models;

namespace BlazorFront.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetEmployee(int id);
    }
}