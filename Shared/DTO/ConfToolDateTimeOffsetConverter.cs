using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TTConfTool.Shared.DTO
{
    public class ConfToolDateTimeOffsetConverter : JsonConverter<DateTime>
    {
        private const string _dateFormat1 = "yyyy-MM-dd HH:mm:ss";
        private const string _dateFormat2 = "yyyy-MM-dd HH:mm:ss.fffffff";

        public override DateTime Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options)
        {
            try
            {
                return DateTime.ParseExact(reader.GetString(), _dateFormat1, CultureInfo.InvariantCulture);
            }
            catch
            {
                return DateTime.ParseExact(reader.GetString(), _dateFormat2, CultureInfo.InvariantCulture);
            }
        }


        public override void Write(
            Utf8JsonWriter writer,
            DateTime value,
            JsonSerializerOptions options) =>
            writer.WriteStringValue(value.ToString(_dateFormat1, CultureInfo.InvariantCulture));
    }
}
