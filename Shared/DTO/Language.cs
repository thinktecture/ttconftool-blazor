using System.Text.Json.Serialization;

namespace TTConfTool.Shared.DTO
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Language
    {
        DE,
        EN
    };
}
