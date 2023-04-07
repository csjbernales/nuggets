namespace linq
{
    public static class Helpers
    {
        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new()
            {
                new Employee()
                {
                    Id = 1,
                    FirstName = "Clark",
                    LastName = "Bernales"
                },
                new Employee()
                {
                    Id = 2,
                    FirstName = "Verna",
                    LastName = "Dorias"
                },
            };

            return employees;
        }

        public static List<Department> GetDepartments()
        {
            List<Department> departments = new()
            {
                new Department()
                {
                    Id = 1,
                    Name = "Department 1"
                },
                new Department()
                {
                    Id = 2,
                    Name = "Department 2"
                },
            };

            return departments;
        }
    }
}