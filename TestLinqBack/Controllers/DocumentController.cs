using Microsoft.AspNetCore.Mvc;
using TestLinqBack.Contracts;

namespace TestLinqBack.Controllers;
/// <summary>
/// Контроллер для управления операциями с документами.
/// </summary>
public class DocumentController : ControllerBase
{
    // Сервис с логикой работы с документами
    private readonly IDocumentService _documentService;

    /// <summary>
    /// Получаем сервис через внедрение зависимостей (DI) - способ организации кода, при котором объекты  не создают =>
    /// => свои зависимости(внешний компонент, нужный для работы классу) самостоятельно, а получают извне.
    /// Вызывается при создании контроллера
    /// </summary>
    /// <param name="documentService">Сервис для работы с документами</param>
    public DocumentController(IDocumentService documentService)
    {
        _documentService = documentService;
    }

    /// <summary>
    /// Получение списка всех документов без дублей
    /// </summary>
    /// <returns>Результат выполнения запроса с документами без копий</returns>
    [HttpGet("api/document/get-documents")]
    public IActionResult GetDocuments()
    {
        return Ok(_documentService.GetDocuments());
    }
}