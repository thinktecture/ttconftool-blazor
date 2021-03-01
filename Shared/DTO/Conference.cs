using System;

namespace TTConfTool.Shared.DTO
{
    public class Conference
    {
        public long ID { get; set; }
        public string Title { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Url { get; set; }
        public int ContributionsCount { get; set; }
        public int SpeakerCount { get; set; }
        public DateTime? CfpStart { get; set; }
        public DateTime? CfpDeadline { get; set; }
    }
}
