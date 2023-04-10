using getpostapi.Models;

namespace getpostapi.Services
{
    public interface IEmployeeServices
    {
        Task<List<Employee>> AddNewEmployee(Employee employee);
        Task<List<Employee>> GetAllEmployees();
    }
}