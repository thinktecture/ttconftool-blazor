using System;
using System.Text.Json.Serialization;
using TTConfTool.Shared.Json;

namespace TTConfTool.Shared.DTO
{
    public class Conference
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] 
        public long ID { get; set; }
        public string Title { get; set; }
        [JsonConverter(typeof(ConfToolDateTimeOffsetConverter))] 
        public DateTime? DateFrom { get; set; }
        [JsonConverter(typeof(ConfToolDateTimeOffsetConverter))] 
        public DateTime? DateTo { get; set; }
        public Country Country { get; set; }
        public string City { get; set; }
        public string Url { get; set; }
        public int ContributionsCount { get; set; }
        public int SpeakerCount { get; set; }
        [JsonConverter(typeof(ConfToolDateTimeOffsetConverter))] 
        public DateTime? CfpStart { get; set; }
        [JsonConverter(typeof(ConfToolDateTimeOffsetConverter))] 
        public DateTime? CfpDeadline { get; set; }
    }
}
