using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TTConfTool.Shared.DTO
{
    public class Contribution
    {
        public long ID { get; set; }
        public ContributionType Type { get; set; }
        public string Title { get; set; }
        [JsonConverter(typeof(ConfToolDateTimeOffsetConverter))]
        public DateTime Date { get; set; }
        public Country Language { get; set; }
        public bool Billed { get; set; }
        public string Abstract { get; set; }
        public List<Media> Media { get; set; }
        public string PreviewSrc { get; set; }
        public List<long> Speaker { get; set; }
        public List<string> Tags { get; set; }
        public bool? ExternalSpeaker { get; set; }
        public string Time { get; set; }
        public string UrlFragment { get; set; }
        public string BigmarkerRef { get; set; }
        public string CtaKey { get; set; }
        public string AdditionalInfo { get; set; }
        public long? Conference { get; set; }
    }
}
