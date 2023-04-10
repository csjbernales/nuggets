namespace linq
{
    public static class Program
    {
        public static void Main()
        {
            List<Employee> employeesList = Helpers.GetEmployees();

            var filteredEmployees = employeesList.Filter(employee => employee.Id == 1);

            Console.WriteLine(filteredEmployees.First().FirstName);
        }


    }
}