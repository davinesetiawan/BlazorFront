using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorFront.Models;

namespace BlazorFront.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetEmployees(); //list kembalian dari Employee
        Task<Employee> GetEmployee(int id);
        Task<Employee> Add(Employee employee);
        Task<Employee> Update(int id, Employee employee);
        Task<Employee> Delete(int id);
    }
}