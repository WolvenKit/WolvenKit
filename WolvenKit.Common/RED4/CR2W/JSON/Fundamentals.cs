using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.CR2W.JSON;


public class CBoolConverter : JsonConverter<CBool>, ICustomRedConverter
{
    public object ReadRedType(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => Read(ref reader, typeToConvert, options);

    public override CBool Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => reader.GetByte();

    public override void Write(Utf8JsonWriter writer, CBool value, JsonSerializerOptions options) => writer.WriteNumberValue(value);
}

public class CDoubleConverter : JsonConverter<CDouble>, ICustomRedConverter
{
    public object ReadRedType(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => Read(ref reader, typeToConvert, options);

    public override CDouble Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => reader.GetDouble();

    public override void Write(Utf8JsonWriter writer, CDouble value, JsonSerializerOptions options) => writer.WriteNumberValue(value);
}

public class CFloatConverter : JsonConverter<CFloat>, ICustomRedConverter
{
    public object ReadRedType(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => Read(ref reader, typeToConvert, options);

    public override CFloat Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.String)
        {
            var str = reader.GetString();
            if (str is null)
            {
                throw new JsonException();
            }

            if (str.ToLower() == "+inf")
            {
                return float.PositiveInfinity;
            }
            else if (str.ToLower() == "-inf")
            {
                return float.NegativeInfinity;
            }
            else
            {
                throw new JsonException();
            }
        }
        else if (reader.TokenType == JsonTokenType.Number)
        {
            return reader.GetSingle();
        }

        throw new JsonException();
    }

    public override void Write(Utf8JsonWriter writer, CFloat value, JsonSerializerOptions options)
    {
        if (float.IsPositiveInfinity(value))
        {
            writer.WriteStringValue("+inf");
        }
        else if (float.IsNegativeInfinity(value))
        {
            writer.WriteStringValue("-inf");
        }
        else
        {
            writer.WriteNumberValue(value);
        }
    }
}

public class CInt8Converter : JsonConverter<CInt8>, ICustomRedConverter
{
    public object ReadRedType(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => Read(ref reader, typeToConvert, options);

    public override CInt8 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => reader.GetSByte();

    public override void Write(Utf8JsonWriter writer, CInt8 value, JsonSerializerOptions options) => writer.WriteNumberValue(value);
}

public class CInt16Converter : JsonConverter<CInt16>, ICustomRedConverter
{
    public object ReadRedType(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => Read(ref reader, typeToConvert, options);

    public override CInt16 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => reader.GetInt16();

    public override void Write(Utf8JsonWriter writer, CInt16 value, JsonSerializerOptions options) => writer.WriteNumberValue(value);
}

public class CInt32Converter : JsonConverter<CInt32>, ICustomRedConverter
{
    public object ReadRedType(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => Read(ref reader, typeToConvert, options);

    public override CInt32 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => reader.GetInt32();

    public override void Write(Utf8JsonWriter writer, CInt32 value, JsonSerializerOptions options) => writer.WriteNumberValue(value);
}

public class CInt64Converter : JsonConverter<CInt64>, ICustomRedConverter
{
    public object ReadRedType(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => Read(ref reader, typeToConvert, options);

    public override CInt64 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => reader.GetInt64();

    public override void Write(Utf8JsonWriter writer, CInt64 value, JsonSerializerOptions options) => writer.WriteNumberValue(value);
}

public class CUInt8Converter : JsonConverter<CUInt8>, ICustomRedConverter
{
    public object ReadRedType(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => Read(ref reader, typeToConvert, options);

    public override CUInt8 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => reader.GetByte();

    public override void Write(Utf8JsonWriter writer, CUInt8 value, JsonSerializerOptions options) => writer.WriteNumberValue(value);
}

public class CUInt16Converter : JsonConverter<CUInt16>, ICustomRedConverter
{
    public object ReadRedType(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => Read(ref reader, typeToConvert, options);

    public override CUInt16 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => reader.GetUInt16();

    public override void Write(Utf8JsonWriter writer, CUInt16 value, JsonSerializerOptions options) => writer.WriteNumberValue(value);
}

public class CUInt32Converter : JsonConverter<CUInt32>, ICustomRedConverter
{
    public object ReadRedType(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => Read(ref reader, typeToConvert, options);

    public override CUInt32 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => reader.GetUInt32();

    public override void Write(Utf8JsonWriter writer, CUInt32 value, JsonSerializerOptions options) => writer.WriteNumberValue(value);
}

public class CUInt64Converter : JsonConverter<CUInt64>, ICustomRedConverter
{
    public object ReadRedType(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => Read(ref reader, typeToConvert, options);

    public override CUInt64 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => reader.GetUInt64();

    public override void Write(Utf8JsonWriter writer, CUInt64 value, JsonSerializerOptions options) => writer.WriteNumberValue(value);
}


