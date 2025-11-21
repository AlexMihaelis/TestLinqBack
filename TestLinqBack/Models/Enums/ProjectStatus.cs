using System.Text.Json.Serialization;

namespace TestLinqBack.Models.Enums;
/// <summary>
/// Определение жизненного цикла проекта/статуса проекта
/// [JsonConverter(typeof(JsonStringEnumConverter))] - конвертирует значения Enum (перечисления) в строки при сериализации/десериализации JSON
/// public - публичный модификатор доступа
/// Draft - черновик (стадия планирования)
/// InProgress -  в разработке
/// Completed -  завершен
/// Archive - архивирован (только для чтения/анализа)
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ProjectStatus
{
    Draft,
    InProgress,
    Completed,
    Archived
}