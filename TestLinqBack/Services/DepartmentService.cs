using System.Runtime.Intrinsics.X86;
using TestLinqBack.Contracts;
using TestLinqBack.Data;
using TestLinqBack.Models;
using TestLinqBack.Models.DTO;
using TestLinqBack.Models.Enums;

namespace TestLinqBack.Services;

public class DepartmentService : IDepartmentService
{
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