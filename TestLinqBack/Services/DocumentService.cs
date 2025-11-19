using TestLinqBack.Contracts;
using TestLinqBack.Data;
using TestLinqBack.Models;

namespace TestLinqBack.Services;

public class DocumentService : IDocumentService
{
    public IEnumerable<Document> GetDocuments()
    {
        return LinqData.Projects.SelectMany(d => d.Documents)
            .DistinctBy(d => d.Id);
    }
}