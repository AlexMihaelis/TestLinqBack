using Microsoft.AspNetCore.Mvc;
using TestLinqBack.Contracts;
using TestLinqBack.Data;
using TestLinqBack.Models.Enums;

namespace TestLinqBack.Controllers;
/// <summary>
/// Контроллер для управления операциями с проектами.
/// </summary>
public class ProjectController : ControllerBase
{
    // Сервис с логикой работы с проектами
    private readonly IProjectService _projectService;

    /// <summary>
    /// Получаем сервис через внедрение зависимостей (DI) - способ организации кода, при котором объекты  не создают =>
    /// => свои зависимости(внешний компонент, нужный для работы классу) самостоятельно, а получают извне.
    /// Вызывается при создании контроллера
    /// </summary>
    /// <param name="projectService">Сервис для работы с проектами</param>
    public ProjectController(IProjectService projectService)
    {
        _projectService = projectService;
    }

    /// <summary>
    /// Поиск документов в активных проектах (inProgress), у которых расход больше прибыли 
    /// </summary>
    /// <returns>Результат выполнения запроса с активными проектами, у которых расходы больше прибыли</returns>
    [HttpGet("api/project/get-project-documents")]
    public IActionResult GetDocProjects()
    {
        return Ok(_projectService.GetDocProjects());
    }

    /// <summary>
    /// Фильтрация проектов по названию и статусу. Получение проектов по названию и статусу
    /// </summary>
    /// <param name="name">Наименование проекта с фронта</param>
    /// <param name="status">Статус проекта с фронта</param>
    /// <returns>Результат выполнения запроса список проектов по названию и статусу</returns>
    [HttpGet("api/project/get-projects")]
    public IActionResult GetProjects(string name, ProjectStatus status)
    {
        return Ok(_projectService.GetProjects(name, status));
    }
    
    /// <summary>
    /// Поиск проектов, которые не имеют ни одного документа
    /// </summary>
    /// <returns>Результат выполнения запроса список проектов, у которых нет ни одного документа</returns>
    [HttpGet("api/project/get-projects-no-documents")]
    public IActionResult GetProjectsNoDocuments()
    {
        return Ok(_projectService.GetProjectsNoDocuments());
    }
    
    /// <summary>
    /// Агрегация финансов документов. Поиск суммы расходов и прибыли по каждому проекту
    /// </summary>
    /// <returns>Результат выполнения запроса о сумме расходов и прибыли по каждому проекту</returns>
    [HttpGet("api/project/get-expenses-profit-sum-projects")]
    public IActionResult GetExpensesProfitSumProjects()
    {
        return Ok(_projectService.GetExpensesProfitSumProjects());
    }
    
    /// <summary>
    /// Получение объединенного списка проектов пользователя/сотрудника, а также тех проектов, где он менеджер
    /// </summary>
    /// <param name="userId">Id пользователя/сотрудника, получаемое с фронта</param>
    /// <returns>Результат выполнения запроса объединенный список проектов пользователя/сотрудника, а также проектов, где он менеджер</returns>
    [HttpGet("api/project/get-all-projects-by-user")]
    public IActionResult GetAllProjectsByUser(int userId)
    {
        return Ok(_projectService.GetAllProjectsByUser(userId));
    }

    /// <summary>
    /// Поиск проектов менеджера
    /// </summary>
    /// <param name="managerId">Id менеджера, получаемое с фронта</param>
    /// <returns>Результат выполнения запроса по поиску проектов менеджера</returns>
    [HttpGet("api/project/get-projects-by-manager")]
    public IActionResult GetManagerProjects(int managerId)
    {
        return Ok(_projectService.GetManagerProjects(managerId));
    }
}