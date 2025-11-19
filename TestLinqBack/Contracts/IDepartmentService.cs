using TestLinqBack.Models;
using TestLinqBack.Models.DTO;

namespace TestLinqBack.Contracts;

public interface IDepartmentService 
{
    List<DepartmentSalarysSumDTO> GetDepartmentSalarysSum();
    Department GetDepartmentMaxAvgSalarys();
    IEnumerable<Department> GetDepartWithActiveProjects();
}