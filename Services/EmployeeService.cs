using System;
using System.Runtime.CompilerServices;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using BlazorFront.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace BlazorFront.Services
{
    public class EmployeeService : IEmployeeService
    {
        private HttpClient _httpClient; 
        public EmployeeService(HttpClient httpClient) //inject http client utk ambil data dari API
        {
            _httpClient = httpClient;
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

        public async Task<Employee> Update(int id, Employee employee)
        {
            var respone = await _httpClient.PutAsJsonAsync($"api/Employees/{id}",employee);
            if(respone.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<Employee>(await respone.Content.ReadAsStreamAsync());
            }else
                {
                    throw new Exception("Gagal update Employee");
                }
        }

        public async Task<Employee> Add(Employee obj)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/Employees",obj);
                if(response.IsSuccessStatusCode)
                {
                    return await JsonSerializer.DeserializeAsync<Employee>(await response.Content.ReadAsStreamAsync());
                }else
                    {
                        throw new Exception("gagal tambah data Employee");
                    }
        }

        public Task<Employee> Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}