using TestLinqBack.Models;

namespace TestLinqBack.Contracts;
/// <summary>
/// Интерфейс определяет функциональность для работы с отделами
/// public - публичный модификатор доступа
/// </summary>
public interface IDocumentService
{
    // // Получение списка всех документов без дублей
    IEnumerable<Document> GetDocuments(); 
}