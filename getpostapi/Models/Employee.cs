namespace getpostapi.Models
{
    public class Employee
    {
        public required string Firstname { get; set; }
        public string Middlename { get; set; } = string.Empty;
        public required string Lastname { get; set; }
    }
}
