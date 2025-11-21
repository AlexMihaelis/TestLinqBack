using Microsoft.AspNetCore.Mvc;
using TestLinqBack.Contracts;
using TestLinqBack.Models.DTO;

namespace TestLinqBack.Controllers;
/// <summary>
/// Контроллер для управления операциями с пользователями/сотрудниками.
/// </summary>
public class UserController : ControllerBase
{
    // Сервис с логикой работы с пользователями/сотрудниками
    private readonly IUserService _userService;

    /// <summary>
    /// Получаем сервис через внедрение зависимостей (DI) - способ организации кода, при котором объекты  не создают =>
    /// => свои зависимости(внешний компонент, нужный для работы классу) самостоятельно, а получают извне.
    /// Вызывается при создании контроллера
    /// </summary>
    /// <param name="userService">Сервис для работы с проектами</param>
    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    /// <summary>
    /// Поиск пользователей/сотрудников по зарплате
    /// </summary>
    /// <param name="salary">Зарплата пользователя/сотрудника с фронта</param>
    /// <returns>Результат выполнения запроса список сотрудников с за, больше полученного значения с фронта</returns>
    [HttpGet ("api/users/get-user-salary")]
    public IActionResult GetUsersSalary(decimal salary)
    {
        return Ok(_userService.GetUsersSalary(salary));
    }

    /// <summary>
    /// Получение ролей пользователей/сотрудников без дублей
    /// </summary>
    /// <returns>Результат выполнения запроса списка уникальных (без повторов) ролей пользователей/сотрудников</returns>
    [HttpGet("api/users/get-user-role")]
    public IActionResult GetUsersRole()
    {
        return Ok(_userService.GetUsersRole());
    }
    
    /// <summary>
    /// Поиск часто встречающейся роли
    /// </summary>
    /// <returns>Результат выполнения запроса роль, которая встречается часто</returns>
    [HttpGet("api/users/get-frequent-role")]
    public IActionResult GetFrequentRole()
    {
        return Ok(_userService.GetFrequentRole());
    }

    /// <summary>
    /// Получение пользователя/сотрудника, а также все его актуальные проекты с документами
    /// </summary>
    /// <param name="userId">Id пользователя/сотрудника с фронта</param>
    /// <returns>Результат выполнения запроса список актуальных проектов сотрудника/пользователя (полученного с фронта) с документами</returns>
    [HttpGet("api/users/get-user-actual-projects")]
    public IActionResult GetUserActualProjects(int userId)
    {
        return Ok(_userService.GetUserActualProjects(userId));
    }
    
    /// <summary>
    /// Получение пары "Пользователь – Проект"
    /// </summary>
    /// <returns>Результат выполнения запроса список пар "пользователь - проект" </returns>
    [HttpGet("api/users/get-user-projects")]
    public IActionResult GetUserProject()
    {
        return Ok(_userService.GetUserProject());
    }
    
    /// <summary>
    /// Поиск всех пользователей/сотрудников, которые участвуют хотя бы в одном проекте
    /// </summary>
    /// <param name="searchTerms">Название проекта с фронта</param>
    /// <returns>Результат выполнения запроса список пользователей/сотрудников, которые участвуют хотя бы в 1 проекте</returns>
    [HttpGet("api/users/get-user-at-least-in-one-project")]
    public IActionResult GetUsersAtLeastInOneProject(string searchTerms)
    {
        return Ok(_userService.GetUsersAtLeastInOneProject(searchTerms));
    } 
}