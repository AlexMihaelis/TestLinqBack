namespace TestLinqBack.Models;

public class User
{
    public int Id { get; set; }
    
    public string Username { get; set; }
    
    public string Email { get; set; }
    
    public int DepartmentId { get; set; }
    
    public List<Project> Projects { get; set; }
    
    public decimal Salary { get; set; }
    
    public string Role { get; set; }
}