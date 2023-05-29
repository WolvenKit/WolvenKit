using System.Text.Json;

namespace WolvenKit.RED4.CR2W.JSON;

public static class Utf8JsonWriterExtension
{
    public static void WriteCustomNumberValue(this Utf8JsonWriter writer, long value)
    {
        if (RedJsonSerializer.RedOptions.LongAsString)
        {
            writer.WriteStringValue(value.ToString());
        }
        else
        {
            writer.WriteNumberValue(value);
        }
    }

    public static void WriteCustomNumberValue(this Utf8JsonWriter writer, ulong value)
    {
        if (RedJsonSerializer.RedOptions.LongAsString)
        {
            writer.WriteStringValue(value.ToString());
        }
        else
        {
            writer.WriteNumberValue(value);
        }
    }
}