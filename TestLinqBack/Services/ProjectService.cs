using TestLinqBack.Contracts;
using TestLinqBack.Data;
using TestLinqBack.Models;
using TestLinqBack.Models.DTO;
using TestLinqBack.Models.Enums;

namespace TestLinqBack.Services;
/// <summary>
/// Класс ProjectService, представляющий из себя модель данных
/// Класс ProjectService реализует интерфейс IProjectService
/// Service - бизнес-логика, агрегация данных (объединение и обработка информации из нескольких источников или элементов =>
/// => для получения сводных показателей)
/// {get; set;} - аксессоры/методы доступа - автоматические свойства, позволяющие читать и изменять значения полей. =>
/// => Обеспечивают контроль над данными и инкапсуляцию.
/// get - получить (чтение)
/// set - установить (запись)
/// public - публичный модификатор доступа
/// class - тип данных, описывающий некую сущность (шаблон/"чертеж" для создания объектов, определяющий =>
/// => их структуру (поля, данные) и поведение (методы, функции)
/// </summary>
public class ProjectService : IProjectService
{
    // Поиск документов в активных проектах (inProgress), у которых расход больше прибыли 
    public IEnumerable<Document> GetDocProjects()
    {
        return LinqData.Projects.Where(s => s.Status == ProjectStatus.InProgress)
            .SelectMany(ep => ep.Documents.Where(e => e.Expenses > e.Profit));
    }

    // Задает, разве что Статус числами (1, 2 и тп) - UPD: зафигачен ненужный костыль :)
    // Фильтрация проектов по названию и статусу. Получение проектов по названию и статусу
    public IEnumerable<Project> GetProjects(string name, ProjectStatus status)
    {
        return LinqData.Projects.Where(p => (p.Name.Contains(name)) && p.Status == status);
    }
    
    // Поиск проектов, которые не имеют ни одного документа
    public IEnumerable<Project> GetProjectsNoDocuments()
    {
        return LinqData.Projects.Where(d => !d.Documents.Any());
    }

    // Агрегация финансов документов. Поиск суммы расходов и прибыли по каждому проекту
    public IEnumerable<ExpensesProfitSumProjectsDTO> GetExpensesProfitSumProjects()
    {
        return LinqData.Projects.Select(p => new ExpensesProfitSumProjectsDTO
        {
            ProjectName = p.Name,
            TotalExpenses = p.Documents.Sum(d => d.Expenses),
            TotalProfits = p.Documents.Sum(d => d.Profit)
        });
    }

    // Получение объединенного списка проектов пользователя/сотрудника, а также тех проектов, где он менеджер
    public IEnumerable<Project> GetAllProjectsByUser(int userId)
    {
        return LinqData.Users.First(u => u.Id == userId).Projects
            .Union(LinqData.Projects.Where(p => p.ManagerId == userId));
    }

    // Поиск проектов менеджера
    public IEnumerable<Project> GetManagerProjects(int managerId)
    {
        return LinqData.Projects.Where(p => p.ManagerId == managerId);
    }
}