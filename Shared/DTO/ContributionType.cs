using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace TTConfTool.Shared.DTO
{
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum ContributionType
    {
        [EnumMember(Value = "Half Day Workshop")]
        HalfDayWorkshop,
        Keynote,
        Talk,
        Webinar,
        Workshop
    };
}
