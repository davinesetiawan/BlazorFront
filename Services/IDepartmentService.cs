using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorFront.Models;

namespace BlazorFront.Services
{
    public interface IDepartmentService
    {
         Task<IEnumerable<Department>> GetAll();
         Task<Department> GetById(int id);
    }
}