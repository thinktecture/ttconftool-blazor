using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TTConfTool.Shared.Json
{
    public class ConfToolDateTimeOffsetConverter : JsonConverter<DateTime?>
    {
        private const string _dateFormat1 = "yyyy-MM-dd HH:mm:ss";
        private const string _dateFormat2 = "yyyy-MM-dd HH:mm:ss.fffffff";
        private const string _dateFormat3 = "yyyy-MM-dd'T'HH:mm:ss.fff'Z'";

        public override bool HandleNull => true;

        public override DateTime? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if(reader.GetString() is null)
            {
                return null;
            }

            try
            {
                return DateTime.ParseExact(reader.GetString(), _dateFormat1, CultureInfo.InvariantCulture);
            }
            catch
            {
                try
                {
                    return DateTime.ParseExact(reader.GetString(), _dateFormat2, CultureInfo.InvariantCulture);
                }
                catch (Exception)
                {
                    return DateTime.Parse(reader.GetString(), CultureInfo.InvariantCulture);
                }
            }
        }

        public override void Write(Utf8JsonWriter writer, DateTime? value, JsonSerializerOptions options)
        {
            if(value is null)
            {
                writer.WriteStringValue(string.Empty);
            }
            else
            {
                writer.WriteStringValue(value.Value.ToString(_dateFormat3, CultureInfo.InvariantCulture));
            }
        }
    }
}
