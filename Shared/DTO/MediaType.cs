using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace TTConfTool.Shared.DTO
{
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum MediaType
    {
        [EnumMember(Value = "Code Sample")]
        CodeSample,
        [EnumMember(Value = "Online-Demo")]
        OnlineDemo,
        [EnumMember(Value = "Related Link")]
        RelatedLink,
        Slides,
        [EnumMember(Value = "Slides-Originalformat")]
        SlidesOriginalformat,
        Speakerdeck,
        Video
    };
}
