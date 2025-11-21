using TestLinqBack.Models.Enums;

namespace TestLinqBack.Models;
/// <summary>
/// Класс Project (Проект), представляющий из себя модель данных
/// {get; set;} - аксессоры/методы доступа - автоматические свойства, позволяющие читать и изменять значения полей. =>
/// => Обеспечивают контроль над данными и инкапсуляцию.
/// get - получить (чтение)
/// set - установить (запись)
/// public - публичный модификатор доступа
/// class - тип данных, описывающий некую сущность (шаблон/"чертеж" для создания объектов, определяющий =>
/// => их структуру (поля, данные) и поведение (методы, функции)
/// </summary>
public class Project
{
    public int Id { get; set; } // Id - целочисленный идентификатор (первичный ключ)
    
    public string Name { get; set; } // Name - строка для хранения названия документа
    
    public string Description { get; set; } // Description - описание проекта
    
    public List<Document> Documents { get; set; } // Documents - коллекция связанных документов ("1 к М")
    
    public ProjectStatus Status { get; set; } // Status - перечисление (Enum) с состояниями проекта/его статус
    
    public DateTime CreatedAt { get; set; } // CreatedAt - автоматическая установка ДАТЫ И ВРЕМЕНИ при создании объекта
    
    // DateTime? - значение может быть null, если срок не задан
    public DateTime? Deadline { get; set; } // Deadline - срок выполнения проекта
    
    public int ManagerId { get; set; } // ManagerId - идентификатор-ссылка на менеджера проекта (вторичный ключ)
}
