using System;
using System.Linq;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorFront.Models;
using System.Net.Http.Json;

namespace BlazorFront.Services 
{
    public class DepartmentService : IDepartmentService
    {
        private HttpClient _httpClient; //akses API yg sudah tersedia

        public DepartmentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<Department>> GetAll() 
        {
            var results = await _httpClient.GetFromJsonAsync<IEnumerable<Department>>("api/Departments");
            return results;
        }

        public async Task<Department> GetById(int id) 
        {
            var result = await _httpClient.GetFromJsonAsync<Department>($"api/Departments/{id}");
            return result;
        }
    }
}