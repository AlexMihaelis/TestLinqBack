using TestLinqBack.Contracts;
using TestLinqBack.Data;
using TestLinqBack.Models;
using TestLinqBack.Models.DTO;
using TestLinqBack.Models.Enums;

namespace TestLinqBack.Services;
/// <summary>
/// Класс UserService, представляющий из себя модель данных
/// Класс UserService реализует интерфейс IUserService
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
public class UserService : IUserService
{
    // Поиск пользователей/сотрудников по зарплате
    public IEnumerable<User> GetUsersSalary(decimal salary)
    {
        return LinqData.Users.Where(s => s.Salary > salary);
    }

    // Получение ролей пользователей/сотрудников без дублей
    public IEnumerable<RoleDTO> GetUsersRole()
    {
        return LinqData.Users.Select(u => new RoleDTO { Name = u.Role })
            .DistinctBy(u => u.Name);
    }

    // Поиск часто встречающейся роли
    public RoleDTO GetFrequentRole()
    {
        return new RoleDTO
        {
            Name = LinqData.Users.GroupBy(r => r.Role)
                .OrderByDescending(x => x.Count())
                .Select(y => y.Key)
                .First()
        };
    }
    
    // Получение пользователя/сотрудника, а также все его актуальные проекты с документами
    public IEnumerable<UserActualProjectsDTO> GetUserActualProjects(int userId)
    {
        return LinqData.Users.Where(u => u.Id == userId)
            .SelectMany(u => u.Projects
                .Where(p => (p.Status == ProjectStatus.Draft) || (p.Status == ProjectStatus.InProgress))
                .SelectMany(p => p.Documents
                    .Select(d => new UserActualProjectsDTO
                    {
                        UserName = u.Username,
                        ProjectName = p.Name,
                        DocumentName = d.Name

                    })));
    }
    
    //Как вывести его по форме $"{ИмяПользователя} - {НазваниеПроекта}", если string.Join() не хочет тут работать.
    // Зафигачен временный костыль в UserProjectDTO в виде DisplayName
    
    // Получение пары "Пользователь – Проект"
    public IEnumerable<UserProjectDTO> GetUserProject()
    {
        return LinqData.Users.SelectMany(u => u.Projects, (user, project) => new UserProjectDTO
            {
                UserProject = $"{user.Username} - {project.Name}"
            });
    }

    // Поиск всех пользователей/сотрудников, которые участвуют хотя бы в одном проекте
    public IEnumerable<User> GetUsersAtLeastInOneProject(string searchTerms)
    {
       return LinqData.Users.Where(u => u.Projects.Any(p => p.Name.Contains(searchTerms)));
    }
    
    
}