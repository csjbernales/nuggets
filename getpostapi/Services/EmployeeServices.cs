using getpostapi.Models;

using System.Data;
using System.Data.SqlClient;

namespace getpostapi.Services
{
    public class EmployeeServices : IEmployeeServices
    {
        private const string connstring = "server=laptop-nonps;database=maindb;trusted_connection=true;trustservercertificate=true;";
        public EmployeeServices() { }

        public async Task<List<Employee>> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();

            using SqlConnection connection = new SqlConnection(connstring);
            connection.Open();

            using SqlCommand command2 = new SqlCommand(connstring, connection)
            {
                CommandText = "Select * from employees",
                CommandType = CommandType.Text
            };

            SqlDataReader reader = await command2.ExecuteReaderAsync();

            while (reader.Read())
            {
                employees.Add(new Employee()
                {
                    Firstname = reader["firstname"].ToString()!,
                    Middlename = reader["middlename"].ToString()!,
                    Lastname = reader["lastname"].ToString()!,
                });
            }

            return employees;
        }


        public async Task<List<Employee>> AddNewEmployee(Employee employee)
        {
            using SqlConnection connection = new SqlConnection(connstring);
            connection.Open();

            using SqlCommand command2 = new SqlCommand(connstring, connection)
            {
                CommandText = $"insert into employees values('{employee.Firstname}', '{employee.Middlename}','{employee.Lastname}'",
                CommandType = CommandType.Text
            };

            await command2.ExecuteNonQueryAsync();
            return await GetAllEmployees();
        }

    }
}
