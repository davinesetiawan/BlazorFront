using System.Runtime.CompilerServices;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using BlazorFront.Models;
using System.Net.Http.Json;

namespace BlazorFront.Services
{
    public class EmployeeService : IEmployeeService
    {
        private HttpClient _httpClient; 
        public EmployeeService(HttpClient httpClient) //inject http client utk ambil data dari API
        {
            _httpClient = httpClient;
        }

        public Task<Employee> Add(Employee employee)
        {
            throw new System.NotImplementedException();
        }

        public Task<Employee> Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Employee> GetEmployee(int id)
        {
            var hasil = await _httpClient.GetFromJsonAsync<Employee>($"api/Employees/{id}");
            return hasil;
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            var hasil1 = await _httpClient.GetFromJsonAsync<IEnumerable<Employee>>("api/Employees");
            return hasil1;
        }

        public Task<Employee> Update(int id, Employee employee)
        {
            throw new System.NotImplementedException();
        }
    }
}