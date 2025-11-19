using TestLinqBack.Models;
using TestLinqBack.Models.DTO;
using TestLinqBack.Models.Enums;

namespace TestLinqBack.Contracts;

public interface IProjectService
{
    IEnumerable<Document> GetDocProjects();
    IEnumerable<Project> GetProjects(string name, ProjectStatus status);
    IEnumerable<Project> GetProjectsNoDocuments();
    IEnumerable<ExpensesProfitSumProjectsDTO> GetExpensesProfitSumProjects();
    IEnumerable<Project> GetAllProjectsByUser(int userId);
    IEnumerable<Project> GetManagerProjects(int managerId);
}