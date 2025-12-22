using TestLinqBack.Models;
using TestLinqBack.Models.DTO;
using TestLinqBack.Models.Enums;

namespace TestLinqBack.Contracts;
/// <summary>
/// Интерфейс определяет функциональность для работы с отделами
/// public - публичный модификатор доступа
/// </summary>
public interface IProjectService
{
    // Поиск документов в активных проектах (inProgress), у которых расход больше прибыли 
    IEnumerable<Document> GetDocProjects();
    
    // Фильтрация проектов по названию и статусу. Получение проектов по названию и статусу
    IEnumerable<Project> GetProjects(string name = null, ProjectStatus? status = null);
    
    // Поиск проектов, которые не имеют ни одного документа
    IEnumerable<Project> GetProjectsNoDocuments();
    
    // Агрегация финансов документов. Поиск суммы доходов и прибыли по каждому проекту
    IEnumerable<ExpensesProfitSumProjectsDTO> GetExpensesProfitSumProjects();
    
    // Получение объединенного списка проектов пользователя/сотрудника, а также тех проектов, где он менеджер
    IEnumerable<Project> GetAllProjectsByUser(int userId);

    IEnumerable<UserManagerProjectsDTO> GetAllProjectsByManagerUser();
    
    // Поиск проектов менеджера
    IEnumerable<Project> GetManagerProjects(int managerId);
}