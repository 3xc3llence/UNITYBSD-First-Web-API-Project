namespace UNITYBSD_First_Web_API_Project.Models.Entities
{
    public class Employee
    {
        public Guid Id { get; set; }

        public required string Name { get; set; }

        public required string Email { get; set; }

        public string? Phone { get; set; }

        public decimal Salary { get; set; }
        



    }
}
