using TestLinqBack.Contracts;
using TestLinqBack.Data;
using TestLinqBack.Models;

namespace TestLinqBack.Services;
/// <summary>
/// Класс DocumentService, представляющий из себя модель данных
/// Класс DocumentService реализует интерфейс IDocumentService
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
public class DocumentService : IDocumentService
{
    // Получение списка всех документов без дублей
    public IEnumerable<Document> GetDocuments()
    {
        return LinqData.Projects.SelectMany(d => d.Documents)
            .DistinctBy(d => d.Id);
    }
}