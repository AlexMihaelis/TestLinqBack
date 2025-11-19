using Microsoft.AspNetCore.Mvc;
using TestLinqBack.Contracts;

namespace TestLinqBack.Controllers;

public class DocumentController : ControllerBase
{
    private readonly IDocumentService _documentService;

    public DocumentController(IDocumentService documentService)
    {
        _documentService = documentService;
    }

    [HttpGet("api/document/get-documents")]
    public IActionResult GetDocuments()
    {
        return Ok(_documentService.GetDocuments());
    }
}