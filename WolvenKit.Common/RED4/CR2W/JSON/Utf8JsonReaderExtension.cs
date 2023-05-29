using System.Text.Json;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.CR2W.JSON;

public static class Utf8JsonReaderExtension
{
    public static long GetCustomInt64(this Utf8JsonReader reader)
    {
        if (reader.TokenType == JsonTokenType.String)
        {
            var str = reader.GetString();
            if (str == null || !long.TryParse(str, out var value))
            {
                throw new JsonException();
            }

            return value;
        }

        if (reader.TokenType == JsonTokenType.Number)
        {
            return reader.GetInt64();
        }

        throw new JsonException();
    }

    public static ulong GetCustomUInt64(this Utf8JsonReader reader)
    {
        if (reader.TokenType == JsonTokenType.String)
        {
            var str = reader.GetString();
            if (str == null || !ulong.TryParse(str, out var value))
            {
                throw new JsonException();
            }

            return value;
        }

        if (reader.TokenType == JsonTokenType.Number)
        {
            return reader.GetUInt64();
        }

        throw new JsonException();
    }
}