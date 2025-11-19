using System.Text.Json.Serialization;

namespace TestLinqBack.Models.DTO;

public class UserProjectDTO
{
    //{ИмяПользователя} - {НазваниеПроекта}

    public string UserName { get; set; }

    public string ProjectName { get; set; }

    public string DisplayName
    {
        get
        {
            return $"{UserName} - {ProjectName}";
        }
    }
    
}

