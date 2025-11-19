namespace TestLinqBack.Models;

public class Document
{
    public int Id { get; set; }
    
    public string Name { get; set; }
    
    /// <summary>
    /// Расходы
    /// </summary>
    public int Expenses { get; set; }
    
    /// <summary>
    /// Прибыль
    /// </summary>
    public int Profit { get; set; }
}