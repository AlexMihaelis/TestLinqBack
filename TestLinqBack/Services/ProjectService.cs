using TestLinqBack.Contracts;
using TestLinqBack.Data;
using TestLinqBack.Models;
using TestLinqBack.Models.DTO;
using TestLinqBack.Models.Enums;

namespace TestLinqBack.Services;

public class ProjectService : IProjectService
{
    public IEnumerable<Document> GetDocProjects()
    {
        return LinqData.Projects.Where(s => s.Status == ProjectStatus.InProgress)
            .SelectMany(ep => ep.Documents.Where(e => e.Expenses > e.Profit));
    }

    // Задает, разве что Статус числами (1, 2 и тп) - UPD: зафигачен ненужный костыль :)
    public IEnumerable<Project> GetProjects(string name, ProjectStatus status)
    {
        return LinqData.Projects.Where(p => (p.Name.Contains(name)) && p.Status == status);
    }

    public IEnumerable<Project> GetProjectsNoDocuments()
    {
        return LinqData.Projects.Where(d => !d.Documents.Any());
    }

    public IEnumerable<ExpensesProfitSumProjectsDTO> GetExpensesProfitSumProjects()
    {
        return LinqData.Projects.Select(p => new ExpensesProfitSumProjectsDTO
        {
            ProjectName = p.Name,
            TotalExpenses = p.Documents.Sum(d => d.Expenses),
            TotalProfits = p.Documents.Sum(d => d.Profit)
        });
    }

    public IEnumerable<Project> GetAllProjectsByUser(int userId)
    {
        return LinqData.Users.First(u => u.Id == userId).Projects
            .Union(LinqData.Projects.Where(p => p.ManagerId == userId));
    }

    public IEnumerable<Project> GetManagerProjects(int managerId)
    {
        return LinqData.Projects.Where(p => p.ManagerId == managerId);
    }
}