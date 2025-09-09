namespace UNITYBSD_First_Web_API_Project.Models
{
    public class AddEmployeeDto
    {
        public required string Name { get; set; }

        public required string Email { get; set; }

        public string? Phone { get; set; }

        public decimal Salary { get; set; }
    }
}
