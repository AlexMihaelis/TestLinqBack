using TestLinqBack.Models;
using TestLinqBack.Models.DTO;

namespace TestLinqBack.Contracts;
/// <summary>
/// Интерфейс определяет функциональность для работы с отделами
/// public - публичный модификатор доступа
/// </summary>
public interface IDepartmentService 
{
    // Получение суммы зарплаты отделов
    List<DepartmentSalarysSumDTO> GetDepartmentSalarysSum();
    
    //  Поиск отдела с максимальной средней зарплатой
    Department GetDepartmentMaxAvgSalarys();
    
    // Получение отделов с активным проектами
    IEnumerable<Department> GetDepartWithActiveProjects();
}