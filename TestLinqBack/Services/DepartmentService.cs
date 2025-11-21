using System.Runtime.Intrinsics.X86;
using TestLinqBack.Contracts;
using TestLinqBack.Data;
using TestLinqBack.Models;
using TestLinqBack.Models.DTO;
using TestLinqBack.Models.Enums;

namespace TestLinqBack.Services;
/// <summary>
/// Класс DepartmentService, представляющий из себя модель данных
/// Класс DepartmentService реализует интерфейс IDepartmentService
/// Service - бизнес-логика, агрегация данных ( объединение и обработка информации из нескольких источников или элементов =>
/// => для получения сводных показателей)
/// {get; set;} - аксессоры/методы доступа - автоматические свойства, позволяющие читать и изменять значения полей. =>
/// => Обеспечивают контроль над данными и инкапсуляцию.
/// get - получить (чтение)
/// set - установить (запись)
/// public - публичный модификатор доступа
/// class - тип данных, описывающий некую сущность (шаблон/"чертеж" для создания объектов, определяющий =>
/// => их структуру (поля, данные) и поведение (методы, функции)
/// </summary>
public class DepartmentService : IDepartmentService
{
    // Получение суммы зарплаты отделов
    public List<DepartmentSalarysSumDTO> GetDepartmentSalarysSum()
    {
        return LinqData.Users.GroupBy(d => d.DepartmentId)
            .Join(
                LinqData.Departments,
                du => du.Key,
                ud => ud.Id,
                (users, department) =>
                {
                    return new DepartmentSalarysSumDTO
                    {
                        DepartmentName = department.Name,
                        SumSalary = users.Sum(s => s.Salary),
                        UserCount = users.Count()
                    };
                }).ToList();
    }

    //  Поиск отдела с максимальной средней зарплатой
    public Department GetDepartmentMaxAvgSalarys()
    {
        return LinqData.Users.GroupBy(u => u.DepartmentId)
            .Join(
                LinqData.Departments,
                du => du.Key,
                ud => ud.Id,
                (users, department) => new
                {
                    Department = department,
                    AverageSalary = users.Average(s => s.Salary)
                })
            .OrderByDescending(s => s.AverageSalary)
            .First().Department;
    }

    // Получение отделов с активным проектами
    public IEnumerable<Department> GetDepartWithActiveProjects()
    {
        
        return LinqData.Users.GroupBy(u => u.DepartmentId)
            .Join(
                LinqData.Departments,
                u => u.Key,
                d => d.Id,   
                (userGroup, department) => new
                {
                    Department = department,
                    Users = userGroup
                })
            .Where(x => x.Users.Any(u => u.Projects.Any(p => p.Status == ProjectStatus.InProgress)))
            .Select(x => x.Department);
    }
}