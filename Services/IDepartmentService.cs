using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorFront.Models;

namespace BlazorFront.Services
{
    public interface IDepartmentService
    {
         Task<IEnumerable<Department>> GetAll(); //mengambil semua data 
         Task<Department> GetById(int id); //mengambil 1 data saja
    }
}