using TestLinqBack.Models;
using TestLinqBack.Models.DTO;

namespace TestLinqBack.Contracts;

public interface IUserService
{
    IEnumerable<User> GetUsersSalary(decimal salary);
    IEnumerable<RoleDTO> GetUsersRole();
    RoleDTO GetFrequentRole();
    IEnumerable<UserActualProjectsDTO> GetUserActualProjects(int userId);
    IEnumerable<User> GetUsersAtLeastInOneProject(string searchTerms);
    IEnumerable<UserProjectDTO> GetUserProject();
}