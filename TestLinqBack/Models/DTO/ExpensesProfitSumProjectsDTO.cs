namespace TestLinqBack.Models.DTO;
/// <summary>
/// Класс ExpensesProfitSumProjectsDTO (DTO для обработанной информации по сумме всех расходов и прибыли), представляющий из себя модель данных
/// {get; set;} - аксессоры/методы доступа - автоматические свойства, позволяющие читать и изменять значения полей. =>
/// => Обеспечивают контроль над данными и инкапсуляцию.
/// get - получить (чтение)
/// set - установить (запись)
/// public - публичный модификатор доступа
/// class - тип данных, описывающий некую сущность (шаблон/"чертеж" для создания объектов, определяющий =>
/// => их структуру (поля, данные) и поведение (методы, функции)
/// </summary>
public class ExpensesProfitSumProjectsDTO
{
    public string ProjectName { get; set; } // ProjectName - строка для хранения названия проекта
    
    // decimal - тип данных для финансовых расчетов
    public decimal TotalExpenses { get; set; } // TotalExpenses - сумма расходов
    
    // decimal - тип данных для финансовых расчетов
    public decimal TotalProfits { get; set; } // TotalProfits - сумма прибыли
}