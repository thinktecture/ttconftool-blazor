using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TTConfTool.Shared.DTO
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Country
    {
        [Display(Name = "Belgien")]
        BE,
        [Display(Name = "Deutschland")]
        DE,
        [Display(Name = "England")]
        EN,
        [Display(Name = "Niederlande")]
        NL,
        [Display(Name = "Norwegen")]
        NO,
        [Display(Name = "Österreich")]
        AT,
        [Display(Name = "USA")]
        US,
        [Display(Name = "Schweiz")]
        CH,
    };
}
