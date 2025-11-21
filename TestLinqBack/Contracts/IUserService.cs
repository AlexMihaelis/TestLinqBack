using TestLinqBack.Models;
using TestLinqBack.Models.DTO;

namespace TestLinqBack.Contracts;
/// <summary>
/// Интерфейс определяет функциональность для работы с отделами
/// public - публичный модификатор доступа
/// </summary>
public interface IUserService
{
    // Поиск пользователей/сотрудников по зарплате
    IEnumerable<User> GetUsersSalary(decimal salary);
    
    // Получение ролей пользователей/сотрудников без дублей
    IEnumerable<RoleDTO> GetUsersRole();
    
    // Поиск часто встречающейся роли
    RoleDTO GetFrequentRole();
    
    // Получение пользователя/сотрудника, а также все его актуальные проекты с документами
    IEnumerable<UserActualProjectsDTO> GetUserActualProjects(int userId);
    
    // Получение пары "Пользователь – Проект"
    IEnumerable<User> GetUsersAtLeastInOneProject(string searchTerms);
    
    // Поиск всех пользователей, которые участвуют хотя бы в одном проекте
    IEnumerable<UserProjectDTO> GetUserProject();
}