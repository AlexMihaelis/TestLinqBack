using Microsoft.AspNetCore.Mvc;
using TestLinqBack.Contracts;

namespace TestLinqBack.Controllers;
/// <summary>
/// Контроллер для управления операциями с отделами.
/// </summary>
public class DepartmentController : ControllerBase
{
    // Сервис с логикой работы с отделами
    private readonly IDepartmentService _departmentService;
    
    /// <summary>
    /// Получаем сервис через внедрение зависимостей (DI) - способ организации кода, при котором объекты  не создают =>
    /// => свои зависимости(внешний компонент, нужный для работы классу) самостоятельно, а получают извне.
    /// Вызывается при создании контроллера
    /// </summary>
    /// <param name="departmentService">Сервис для работы с отделами</param>
    public DepartmentController(IDepartmentService departmentService)
    {
        _departmentService = departmentService;
    }
    
    /// <summary>
    /// Получение суммы зарплаты отделов
    /// </summary>
    /// <returns>Результат выполнения запроса о сумме зп</returns>
    [HttpGet("api/department/get-deparment-salarys-sum")]
    public IActionResult GetDepartmentSalarysSum()
    {
        return Ok(_departmentService.GetDepartmentSalarysSum());
    }
    
    /// <summary>
    /// Поиск отдела с максимальной средней зарплатой
    /// </summary>
    /// <returns>Результат выполнения запросы о максимальной средней зп</returns>
    [HttpGet("api/department/get-department-max-avg-salarys")]
    public IActionResult GetDepartmentMaxAvgSalarys()
    {
        return Ok(_departmentService.GetDepartmentMaxAvgSalarys());
    }
    
    /// <summary>
    /// Получение отделов с активным проектами
    /// </summary>
    /// <returns>Результат выполнения запроса с активными проектами отделов</returns>
    [HttpGet("api/department/get-department-with-active-projects")]
    public IActionResult GetDepartWithActiveProjects()
    {
        return Ok(_departmentService.GetDepartWithActiveProjects());
    }
}