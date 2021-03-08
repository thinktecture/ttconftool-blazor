using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TTConfTool.Shared.DTO
{
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum Country
    {
        [Display(Name = "Belgien")]
        BE,
        CH,
        [Display(Name = "Deutschland")]
        DE,
        EN,
        NL,
        NO,
        US,
        AT
    };

    public sealed class Countries
    {
        private readonly string name;
        private readonly string value;

        public static readonly Countries AT = new Countries("AT", "Österreich");
        public static readonly Countries BE = new Countries("BE", "Schweiz");
        public static readonly Countries CH = new Countries("CH", "Schweiz");
        public static readonly Countries DE = new Countries("DE", "Deutschland");
        public static readonly Countries EN = new Countries("EN", "England");
        public static readonly Countries NL = new Countries("NL", "Niederlande");
        public static readonly Countries NO = new Countries("NO", "Norwegen");
        public static readonly Countries US = new Countries("US", "USA");

        private Countries(string value, string name)
        {
            this.name = name;
            this.value = value;
        }

        public override string ToString()
        {
            return name;
        }

        public string GetValue()
        {
            return value;
        }
    }
}
