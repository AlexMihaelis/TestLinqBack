using TestLinqBack.Contracts;
using TestLinqBack.Data;
using TestLinqBack.Models;
using TestLinqBack.Models.DTO;
using TestLinqBack.Models.Enums;

namespace TestLinqBack.Services;

public class UserService : IUserService
{
    public IEnumerable<User> GetUsersSalary(decimal salary)
    {
        return LinqData.Users.Where(s => s.Salary > salary);
    }

    public IEnumerable<RoleDTO> GetUsersRole()
    {
        return LinqData.Users.Select(u => new RoleDTO { Name = u.Role })
            .DistinctBy(u => u.Name);
    }

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
    //Страшна, вырубай. Selectselectselectmanyselectselectmanyselectselect
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
    
    //TODO: Как вывести его по форме $"{ИмяПользователя} - {НазваниеПроекта}", если string.Join() не хочет тут работать.
    // Зафигачен временный костыль в UserProjectDTO в виде DisplayName
    public IEnumerable<UserProjectDTO> GetUserProject()
    {
        return LinqData.Users.SelectMany(u => u.Projects, (user, project) => new UserProjectDTO
            {
                UserName =  user.Username,
                ProjectName = project.Name
            });
    }

    // public IEnumerable<User> GetUsersAtLeastInOneProject(IEnumerable<string> searchTerms)
    // {
    //    
    // }
    
    
}