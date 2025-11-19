using System.Text.Json.Serialization;

namespace TestLinqBack.Models.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ProjectStatus
{
    Draft,
    InProgress,
    Completed,
    Archived
}