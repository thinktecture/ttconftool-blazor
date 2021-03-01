using System.Text.Json.Serialization;

namespace TTConfTool.Shared.DTO
{
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum Country
    {
        Be,
        Ch,
        De,
        En,
        Nl,
        No,
        Us,
        At
    };
}
