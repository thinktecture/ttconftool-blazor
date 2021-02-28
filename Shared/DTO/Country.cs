using System.Text.Json.Serialization;

namespace TTConfTool.Shared.DTO
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Country { Be, Ch, De, En, Nl };
}
