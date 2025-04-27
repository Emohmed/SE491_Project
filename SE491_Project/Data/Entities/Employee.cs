namespace SE491_Project.Data.Entities
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public EmployeeRole Role { get; set; }
        public DateTime HireDate { get; set; }
        public bool IsActive { get; set; }

       
    }

    public enum EmployeeRole
    {
        Receptionist,
       
        Admin,
        
    }
}
