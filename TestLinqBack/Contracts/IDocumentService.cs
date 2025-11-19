using TestLinqBack.Models;

namespace TestLinqBack.Contracts;

public interface IDocumentService
{
    IEnumerable<Document> GetDocuments();
}