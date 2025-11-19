using TestLinqBack.Models.Enums;

namespace TestLinqBack.Models;

public class Project
{
    public int Id { get; set; }
    
    public string Name { get; set; }
    
    public string Description { get; set; }
    
    public List<Document> Documents { get; set; }
    
    public ProjectStatus Status { get; set; }
    
    public DateTime CreatedAt { get; set; }
    
    public DateTime? Deadline { get; set; }
    
    public int ManagerId { get; set; }
}
