#nullable enable
using System;
using System.Buffers;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Unicode;
using Semver;
using WolvenKit.Common.Conversion;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.CR2W.JSON;

public interface ICustomRedConverter
{
    public object? ReadRedType(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options);
}

#region Fundmentals

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
            if (str == "+inf")
            {
                return float.PositiveInfinity;
            }
            else if (str == "-inf")
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

#endregion Fundmentals


#region Simples

public class CDateTimeConverter : JsonConverter<CDateTime>, ICustomRedConverter
{
    public object ReadRedType(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => Read(ref reader, typeToConvert, options);

    public override CDateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => reader.GetUInt64();

    public override void Write(Utf8JsonWriter writer, CDateTime value, JsonSerializerOptions options) => writer.WriteNumberValue(value);
}

public class CGuidConverter : JsonConverter<CGuid>, ICustomRedConverter
{
    public object ReadRedType(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => Read(ref reader, typeToConvert, options);

    public override CGuid Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => reader.GetBytesFromBase64();

    public override void Write(Utf8JsonWriter writer, CGuid value, JsonSerializerOptions options) => writer.WriteBase64StringValue((byte[])value);
}

public class CNameConverter : JsonConverter<CName>, ICustomRedConverter
{
    public object ReadRedType(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => Read(ref reader, typeToConvert, options);

    public override CName Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
        {
            return (CName)RedTypeManager.CreateRedType(typeToConvert);
        }

        if (reader.TokenType == JsonTokenType.String)
        {
            return reader.GetString();
        }
        else if (reader.TokenType == JsonTokenType.Number)
        {
            return reader.GetUInt64();
        }
        else
        {
            throw new JsonException();
        }
    }

    public override void Write(Utf8JsonWriter writer, CName value, JsonSerializerOptions options)
    {
        if ((string)value != null)
        {
            writer.WriteStringValue(value);
        }
        else
        {
            writer.WriteNumberValue(value);
        }
    }
}

public class CRUIDConverter : JsonConverter<CRUID>, ICustomRedConverter
{
    public object ReadRedType(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => Read(ref reader, typeToConvert, options);

    public override CRUID Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => reader.GetUInt64();

    public override void Write(Utf8JsonWriter writer, CRUID value, JsonSerializerOptions options) => writer.WriteNumberValue(value);
}

public class CStringConverter : JsonConverter<CString>, ICustomRedConverter
{
    public object ReadRedType(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => Read(ref reader, typeToConvert, options);

    public override CString Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
        {
            return (CString)RedTypeManager.CreateRedType(typeToConvert);
        }

        return reader.GetString();
    }

    public override void Write(Utf8JsonWriter writer, CString value, JsonSerializerOptions options) => writer.WriteStringValue(value);
}

public class CVariantConverter : JsonConverter<CVariant>, ICustomRedConverter
{
    public object? ReadRedType(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => Read(ref reader, typeToConvert, options);

    public override CVariant? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
        {
            return null;
        }

        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        Type? type = null;
        IRedType? result = null;

        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndObject)
            {
                if (result == null)
                {
                    throw new JsonException();
                }

                return new CVariant { Value = result };
            }

            if (reader.TokenType != JsonTokenType.PropertyName)
            {
                throw new JsonException();
            }

            var propertyName = reader.GetString();
            reader.Read();

            switch (propertyName)
            {
                case "Type":
                {
                    if (reader.TokenType != JsonTokenType.String)
                    {
                        throw new JsonException();
                    }

                    (type, _) = RedReflection.GetCSTypeFromRedType(reader.GetString());
                    break;
                }

                case "Value":
                {
                    if (type == null)
                    {
                        throw new JsonException();
                    }

                    var converter = options.GetConverter(type);
                    if (converter is ICustomRedConverter conv)
                    {
                        result = (IRedType?)conv.ReadRedType(ref reader, type, options);
                    }
                    else
                    {
                        result = (IRedType?)JsonSerializer.Deserialize(ref reader, type, options);
                    }

                    break;
                }

                default:
                {
                    throw new JsonException();
                }
            }
        }

        throw new JsonException();
    }

    public override void Write(Utf8JsonWriter writer, CVariant value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        var redTypeName = RedReflection.GetRedTypeFromCSType(value.Value.GetType());
        writer.WriteString("Type", redTypeName);

        writer.WritePropertyName("Value");

        JsonSerializer.Serialize(writer, (object)value.Value, options);

        writer.WriteEndObject();
    }
}

#region BufferConverter

public class BufferConverterFactory : JsonConverterFactory
{
    private readonly DataBufferConverter _dataBufferConverter;
    private readonly SerializationDeferredDataBufferConverter _serializationDeferredDataBufferConverter;
    private readonly SharedDataBufferConverter _sharedDataBufferConverter = new();

    public BufferConverterFactory(ReferenceResolver<RedBuffer> bufferResolver)
    {
        _dataBufferConverter = new(bufferResolver);
        _serializationDeferredDataBufferConverter = new(bufferResolver);
    }

    public override bool CanConvert(Type typeToConvert) => typeof(IRedBufferWrapper).IsAssignableFrom(typeToConvert);

    public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        if (typeToConvert == typeof(DataBuffer))
        {
            return _dataBufferConverter;
        }

        if (typeToConvert == typeof(SerializationDeferredDataBuffer))
        {
            return _serializationDeferredDataBufferConverter;
        }

        if (typeToConvert == typeof(SharedDataBuffer))
        {
            return _sharedDataBufferConverter;
        }

        throw new NotSupportedException("CreateConverter got called on a type that this converter factory doesn't support");
    }
}

public class DataBufferConverter : JsonConverter<DataBuffer>, ICustomRedConverter
{
    private readonly ReferenceResolver<RedBuffer> _referenceResolver;

    public DataBufferConverter(ReferenceResolver<RedBuffer> referenceResolver)
    {
        _referenceResolver = referenceResolver;
    }


    public object? ReadRedType(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => Read(ref reader, typeToConvert, options);

    public override DataBuffer? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
        {
            return null;
        }

        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        string? id = null;
        var val = new DataBuffer();

        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndObject)
            {
                break;
            }

            if (reader.TokenType != JsonTokenType.PropertyName)
            {
                throw new JsonException();
            }

            var propertyName = reader.GetString();
            reader.Read();

            switch (propertyName)
            {
                case "BufferId":
                {
                    if (reader.TokenType != JsonTokenType.String)
                    {
                        throw new JsonException();
                    }

                    id = reader.GetString();
                    if (id == null)
                    {
                        throw new JsonException();
                    }

                    break;
                }

                case "BufferRefId":
                {
                    if (reader.TokenType != JsonTokenType.String)
                    {
                        throw new JsonException();
                    }

                    var refId = reader.GetString();
                    if (refId == null)
                    {
                        throw new JsonException();
                    }

                    val.Buffer = _referenceResolver.ResolveReference(refId);

                    break;
                }

                case "Data":
                {
                    var converter = options.GetConverter(typeof(RedPackage));
                    if (converter is ICustomRedConverter conv)
                    {
                        val.Data = (IParseableBuffer?)conv.ReadRedType(ref reader, typeof(RedPackage), options);
                    }
                    else
                    {
                        throw new JsonException();
                    }

                    break;
                }

                case "Flags":
                {
                    if (reader.TokenType != JsonTokenType.Number)
                    {
                        throw new JsonException();
                    }

                    var flags = reader.GetUInt32();

                    reader.Read();
                    if (reader.TokenType != JsonTokenType.PropertyName)
                    {
                        throw new JsonException();
                    }

                    propertyName = reader.GetString();
                    if (propertyName != "Bytes")
                    {
                        throw new JsonException();
                    }

                    reader.Read();
                    if (reader.TokenType != JsonTokenType.String)
                    {
                        throw new JsonException();
                    }

                    var bytes = reader.GetBytesFromBase64();
                    val.Buffer = RedBuffer.CreateBuffer(flags, bytes);

                    break;
                }

                default:
                {
                    throw new JsonException();
                }
            }
        }

        if (id != null)
        {
            _referenceResolver.AddReference(id, val.Buffer);
        }

        return val;
    }

    public override void Write(Utf8JsonWriter writer, DataBuffer value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        var refId = _referenceResolver.GetReference(value.Buffer, out var alreadyExists);
        if (alreadyExists)
        {
            writer.WriteString("BufferRefId", refId);
        }
        else
        {
            writer.WriteString("BufferId", refId);

            if (value.Buffer.Data is RedPackage pkg)
            {
                writer.WritePropertyName("Data");
                JsonSerializer.Serialize(writer, pkg, options);
            }
            else
            {
                writer.WriteNumber("Flags", value.Buffer.Flags);
                writer.WritePropertyName("Bytes");
                writer.WriteBase64StringValue(value.Buffer.GetBytes());
            }
        }

        writer.WriteEndObject();
    }
}

public class SerializationDeferredDataBufferConverter : JsonConverter<SerializationDeferredDataBuffer>, ICustomRedConverter
{
    private readonly ReferenceResolver<RedBuffer> _referenceResolver;

    public SerializationDeferredDataBufferConverter(ReferenceResolver<RedBuffer> referenceResolver)
    {
        _referenceResolver = referenceResolver;
    }


    public object? ReadRedType(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => Read(ref reader, typeToConvert, options);

    public override SerializationDeferredDataBuffer? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
        {
            return null;
        }

        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        string? id = null;
        var val = new SerializationDeferredDataBuffer();

        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndObject)
            {
                break;
            }

            if (reader.TokenType != JsonTokenType.PropertyName)
            {
                throw new JsonException();
            }

            var propertyName = reader.GetString();
            reader.Read();

            switch (propertyName)
            {
                case "BufferId":
                {
                    if (reader.TokenType != JsonTokenType.String)
                    {
                        throw new JsonException();
                    }

                    id = reader.GetString();
                    if (id == null)
                    {
                        throw new JsonException();
                    }

                    break;
                }

                case "BufferRefId":
                {
                    if (reader.TokenType != JsonTokenType.String)
                    {
                        throw new JsonException();
                    }

                    var refId = reader.GetString();
                    if (refId == null)
                    {
                        throw new JsonException();
                    }

                    val.Buffer = _referenceResolver.ResolveReference(refId);

                    break;
                }

                case "Data":
                {
                    var converter = options.GetConverter(typeof(RedPackage));
                    if (converter is ICustomRedConverter conv)
                    {
                        val.Data = (IParseableBuffer?)conv.ReadRedType(ref reader, typeof(RedPackage), options);
                    }
                    else
                    {
                        throw new JsonException();
                    }

                    break;
                }

                case "Flags":
                {
                    if (reader.TokenType != JsonTokenType.Number)
                    {
                        throw new JsonException();
                    }

                    var flags = reader.GetUInt32();

                    reader.Read();
                    if (reader.TokenType != JsonTokenType.PropertyName)
                    {
                        throw new JsonException();
                    }

                    propertyName = reader.GetString();
                    if (propertyName != "Bytes")
                    {
                        throw new JsonException();
                    }

                    reader.Read();
                    if (reader.TokenType != JsonTokenType.String)
                    {
                        throw new JsonException();
                    }

                    var bytes = reader.GetBytesFromBase64();
                    val.Buffer = RedBuffer.CreateBuffer(flags, bytes);

                    break;
                }

                default:
                {
                    throw new JsonException();
                }
            }
        }

        if (id != null)
        {
            _referenceResolver.AddReference(id, val.Buffer);
        }

        return val;
    }

    public override void Write(Utf8JsonWriter writer, SerializationDeferredDataBuffer value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        var refId = _referenceResolver.GetReference(value.Buffer, out var alreadyExists);
        if (alreadyExists)
        {
            writer.WriteString("BufferRefId", refId);
        }
        else
        {
            writer.WriteString("BufferId", refId);

            if (value.Buffer.Data is RedPackage pkg)
            {
                writer.WritePropertyName("Data");
                JsonSerializer.Serialize(writer, pkg, options);
            }
            else
            {
                writer.WriteNumber("Flags", value.Buffer.Flags);
                writer.WritePropertyName("Bytes");
                writer.WriteBase64StringValue(value.Buffer.GetBytes());
            }
        }

        writer.WriteEndObject();
    }
}

public class SharedDataBufferConverter : JsonConverter<SharedDataBuffer>, ICustomRedConverter
{
    public object? ReadRedType(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => Read(ref reader, typeToConvert, options);

    public override SharedDataBuffer? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
        {
            return null;
        }

        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        reader.Read();

        if (reader.TokenType != JsonTokenType.PropertyName)
        {
            throw new JsonException();
        }

        var propertyName = reader.GetString();
        reader.Read();

        var val = new SharedDataBuffer();
        switch (propertyName)
        {
            case "File":
            {
                //var dto = RedJsonSerializer.Deserialize<RedFileDto>(json);

                var converter = options.GetConverter(typeof(RedFileDto));
                if (converter is ICustomRedConverter conv)
                {
                    var obj = conv.ReadRedType(ref reader, typeof(RedFileDto), options);
                    val.File = ((RedFileDto?)obj)?.Data;
                }
                else
                {
                    throw new JsonException();
                }

                break;
            }

            case "Data":
            {
                var converter = options.GetConverter(typeof(RedPackage));
                if (converter is ICustomRedConverter conv)
                {
                    val.Data = (IParseableBuffer?)conv.ReadRedType(ref reader, typeof(RedPackage), options);
                }
                else
                {
                    throw new JsonException();
                }

                break;
            }

            case "Flags":
            {
                if (reader.TokenType != JsonTokenType.Number)
                {
                    throw new JsonException();
                }

                var flags = reader.GetUInt32();

                reader.Read();
                if (reader.TokenType != JsonTokenType.PropertyName)
                {
                    throw new JsonException();
                }

                propertyName = reader.GetString();
                if (propertyName != "Bytes")
                {
                    throw new JsonException();
                }

                reader.Read();
                if (reader.TokenType != JsonTokenType.String)
                {
                    throw new JsonException();
                }

                var bytes = reader.GetBytesFromBase64();
                val.Buffer = RedBuffer.CreateBuffer(flags, bytes);

                break;
            }

            default:
            {
                throw new JsonException();
            }
        }

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndObject)
        {
            throw new JsonException();
        }

        return val;
    }

    public override void Write(Utf8JsonWriter writer, SharedDataBuffer value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        if (value.File is CR2WFile file)
        {
            writer.WritePropertyName("File");
            JsonSerializer.Serialize(writer, new RedFileDto(file), options);
        }
        else if (value.Data is RedPackage pkg)
        {
            writer.WritePropertyName("Data");
            JsonSerializer.Serialize(writer, pkg, options);
        }
        else
        {
            writer.WriteNumber("Flags", value.Buffer.Flags);
            writer.WritePropertyName("Bytes");
            writer.WriteBase64StringValue(value.Buffer.GetBytes());
        }

        writer.WriteEndObject();
    }
}

#endregion BufferConverter

public class LocalizationStringConverter : JsonConverter<LocalizationString>, ICustomRedConverter
{
    public object? ReadRedType(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => Read(ref reader, typeToConvert, options);

    public override LocalizationString? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
        {
            return null;
        }

        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        var result = new LocalizationString();
        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndObject)
            {
                return result;
            }

            if (reader.TokenType != JsonTokenType.PropertyName)
            {
                throw new JsonException();
            }

            var propertyName = reader.GetString();
            switch (propertyName)
            {
                case "unk1":
                {
                    reader.Read();
                    if (reader.TokenType != JsonTokenType.Number)
                    {
                        throw new JsonException();
                    }

                    result.Unk1 = reader.GetUInt64();
                    break;
                }

                case "value":
                {
                    reader.Read();
                    if (reader.TokenType != JsonTokenType.String)
                    {
                        throw new JsonException();
                    }

                    result.Value = reader.GetString();
                    break;
                }

                default:
                {
                    throw new JsonException();
                }
            }
        }

        throw new JsonException();
    }

    public override void Write(Utf8JsonWriter writer, LocalizationString value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        writer.WriteNumber("unk1", value.Unk1);
        writer.WriteString("value", value.Value);

        writer.WriteEndObject();
    }
}

#region CLegacySingleChannelCurveConverter

public class CLegacySingleChannelCurveConverterFactory : JsonConverterFactory
{
    private readonly CLegacySingleChannelCurveConverter _cLegacySingleChannelCurveConverter = new();

    public override bool CanConvert(Type typeToConvert) => typeof(IRedLegacySingleChannelCurve).IsAssignableFrom(typeToConvert) || typeof(IRedCurvePoint).IsAssignableFrom(typeToConvert);

    public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        if (typeof(IRedLegacySingleChannelCurve).IsAssignableFrom(typeToConvert))
        {
            return _cLegacySingleChannelCurveConverter;
        }

        throw new NotSupportedException("CreateConverter got called on a type that this converter factory doesn't support");
    }
}

public class CLegacySingleChannelCurveConverter : JsonConverter<IRedLegacySingleChannelCurve>, ICustomRedConverter
{
    public object? ReadRedType(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => Read(ref reader, typeToConvert, options);

    public override IRedLegacySingleChannelCurve? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
        {
            return null;
        }

        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        var result = (IRedLegacySingleChannelCurve?)RedTypeManager.CreateRedType(typeToConvert);
        if (result == null)
        {
            throw new JsonException();
        }

        var elementType = result.ElementType;

        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndObject)
            {
                return result;
            }

            if (reader.TokenType != JsonTokenType.PropertyName)
            {
                throw new JsonException();
            }

            var propertyName = reader.GetString();
            reader.Read();

            switch (propertyName)
            {
                case "InterpolationType":
                {
                    if (result == null)
                    {
                        throw new JsonException();
                    }

                    if (reader.TokenType != JsonTokenType.String)
                    {
                        throw new JsonException();
                    }

                    var enumStr = reader.GetString();
                    if (enumStr == null)
                    {
                        throw new JsonException();
                    }

                    result.InterpolationType = Enum.Parse<Enums.EInterpolationType>(enumStr);

                    break;
                }

                case "LinkType":
                {
                    if (result == null)
                    {
                        throw new JsonException();
                    }

                    if (reader.TokenType != JsonTokenType.String)
                    {
                        throw new JsonException();
                    }

                    var enumStr = reader.GetString();
                    if (enumStr == null)
                    {
                        throw new JsonException();
                    }

                    result.LinkType = Enum.Parse<Enums.ESegmentsLinkType>(enumStr);

                    break;
                }

                case "Elements":
                {
                    if (result == null)
                    {
                        throw new JsonException();
                    }

                    if (reader.TokenType != JsonTokenType.StartArray)
                    {
                        throw new JsonException();
                    }

                    while (reader.Read())
                    {
                        if (reader.TokenType == JsonTokenType.EndArray)
                        {
                            break;
                        }

                        if (reader.TokenType != JsonTokenType.StartObject)
                        {
                            throw new JsonException();
                        }

                        reader.Read();
                        if (reader.TokenType != JsonTokenType.PropertyName)
                        {
                            throw new JsonException();
                        }

                        propertyName = reader.GetString();
                        if (propertyName != "Point")
                        {
                            throw new JsonException();
                        }
                        reader.Read();

                        if (reader.TokenType != JsonTokenType.Number)
                        {
                            throw new JsonException();
                        }
                        var point = reader.GetSingle();

                        reader.Read();
                        if (reader.TokenType != JsonTokenType.PropertyName)
                        {
                            throw new JsonException();
                        }

                        propertyName = reader.GetString();
                        if (propertyName != "Value")
                        {
                            throw new JsonException();
                        }

                        object? value;
                        var converter = options.GetConverter(elementType);
                        if (converter is ICustomRedConverter conv)
                        {
                            reader.Read();
                            value = conv.ReadRedType(ref reader, elementType, options);
                        }
                        else
                        {
                            value = JsonSerializer.Deserialize(ref reader, elementType, options);
                        }

                        if (value == null)
                        {
                            throw new JsonException();
                        }

                        reader.Read();
                        if (reader.TokenType != JsonTokenType.EndObject)
                        {
                            throw new JsonException();
                        }

                        result.Add(point, value);
                    }

                    break;
                }

                default:
                {
                    throw new JsonException();
                }
            }
        }

        throw new JsonException();
    }

    public override void Write(Utf8JsonWriter writer, IRedLegacySingleChannelCurve value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        writer.WriteString("InterpolationType", value.InterpolationType.ToString());
        writer.WriteString("LinkType", value.LinkType.ToString());

        writer.WritePropertyName("Elements");
        writer.WriteStartArray();
        foreach (var point in value)
        {
            writer.WriteStartObject();

            writer.WriteNumber("Point", point.GetPoint());

            writer.WritePropertyName("Value");
            JsonSerializer.Serialize(writer, (object)point.GetValue(), options);

            writer.WriteEndObject();
        }
        writer.WriteEndArray();

        writer.WriteEndObject();
    }
}

#endregion CLegacySingleChannelCurveConverter

#region MultiChannelCurveConverter

public class MultiChannelCurveConverterFactory : JsonConverterFactory
{
    private readonly MultiChannelCurveConverter _multiChannelCurveConverter = new();

    public override bool CanConvert(Type typeToConvert) => typeof(IRedMultiChannelCurve).IsAssignableFrom(typeToConvert);

    public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        if (typeof(IRedMultiChannelCurve).IsAssignableFrom(typeToConvert))
        {
            return _multiChannelCurveConverter;
        }

        throw new NotSupportedException("CreateConverter got called on a type that this converter factory doesn't support");
    }
}

public class MultiChannelCurveConverter : JsonConverter<IRedMultiChannelCurve>, ICustomRedConverter
{
    public object? ReadRedType(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => Read(ref reader, typeToConvert, options);

    public override IRedMultiChannelCurve? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
        {
            return null;
        }

        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        var result = (IRedMultiChannelCurve?)RedTypeManager.CreateRedType(typeToConvert);
        if (result == null)
        {
            throw new JsonException();
        }

        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndObject)
            {
                return result;
            }

            if (reader.TokenType != JsonTokenType.PropertyName)
            {
                throw new JsonException();
            }

            var propertyName = reader.GetString();
            reader.Read();

            switch (propertyName)
            {
                case "NumChannels":
                {
                    if (reader.TokenType != JsonTokenType.Number)
                    {
                        throw new JsonException();
                    }

                    result.NumChannels = reader.GetUInt32();

                    break;
                }

                case "InterpolationType":
                {
                    if (reader.TokenType != JsonTokenType.String)
                    {
                        throw new JsonException();
                    }

                    var enumStr = reader.GetString();
                    if (enumStr == null)
                    {
                        throw new JsonException();
                    }

                    result.InterpolationType = Enum.Parse<Enums.EInterpolationType>(enumStr);

                    break;
                }

                case "LinkType":
                {
                    if (reader.TokenType != JsonTokenType.String)
                    {
                        throw new JsonException();
                    }

                    var enumStr = reader.GetString();
                    if (enumStr == null)
                    {
                        throw new JsonException();
                    }

                    result.LinkType = Enum.Parse<Enums.EChannelLinkType>(enumStr);

                    break;
                }

                case "Alignment":
                {
                    if (reader.TokenType != JsonTokenType.Number)
                    {
                        throw new JsonException();
                    }

                    result.Alignment = reader.GetUInt32();

                    break;
                }

                case "Data":
                {
                    if (reader.TokenType != JsonTokenType.String)
                    {
                        throw new JsonException();
                    }

                    result.Data = reader.GetBytesFromBase64();

                    break;
                }

                default:
                {
                    throw new JsonException();
                }
            }
        }

        throw new JsonException();
    }

    public override void Write(Utf8JsonWriter writer, IRedMultiChannelCurve value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        writer.WriteNumber("NumChannels", value.NumChannels);
        writer.WriteString("InterpolationType", value.InterpolationType.ToString());
        writer.WriteString("LinkType", value.LinkType.ToString());
        writer.WriteNumber("Alignment", value.Alignment);
        writer.WriteBase64String("Data", value.Data);

        writer.WriteEndObject();
    }
}

#endregion MultiChannelCurveConverter

public class NodeRefConverter : JsonConverter<NodeRef>, ICustomRedConverter
{
    public object ReadRedType(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => Read(ref reader, typeToConvert, options);

    public override NodeRef Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
        {
            return (NodeRef)RedTypeManager.CreateRedType(typeToConvert);
        }

        if (reader.TokenType == JsonTokenType.String)
        {
            return reader.GetString();
        }
        else if (reader.TokenType == JsonTokenType.Number)
        {
            return reader.GetUInt64();
        }
        else
        {
            throw new JsonException();
        }
    }

    public override void Write(Utf8JsonWriter writer, NodeRef value, JsonSerializerOptions options)
    {
        if ((string)value != null)
        {
            writer.WriteStringValue(value);
        }
        else
        {
            writer.WriteNumberValue(value);
        }
    }
}

public class TweakDBIDConverter : JsonConverter<TweakDBID>, ICustomRedConverter
{
    public object ReadRedType(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => Read(ref reader, typeToConvert, options);

    public override TweakDBID Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
        {
            return (TweakDBID)RedTypeManager.CreateRedType(typeToConvert);
        }

        if (reader.TokenType == JsonTokenType.String)
        {
            return reader.GetString();
        }
        else if (reader.TokenType == JsonTokenType.Number)
        {
            return reader.GetUInt64();
        }
        else
        {
            throw new JsonException();
        }
    }

    public override void Write(Utf8JsonWriter writer, TweakDBID value, JsonSerializerOptions options)
    {
        if ((string)value != null)
        {
            writer.WriteStringValue(value);
        }
        else
        {
            writer.WriteNumberValue(value);
        }
    }
}

#endregion Simples

#region Internal

public class CByteArrayConverter : JsonConverter<CByteArray>, ICustomRedConverter
{
    public object? ReadRedType(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => Read(ref reader, typeToConvert, options);

    public override CByteArray? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
        {
            return null;
        }

        return reader.GetBytesFromBase64();
    }

    public override void Write(Utf8JsonWriter writer, CByteArray value, JsonSerializerOptions options) => writer.WriteBase64StringValue((byte[])value);
}

public class CKeyValuePairConverter : JsonConverter<CKeyValuePair>, ICustomRedConverter
{
    public object? ReadRedType(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => Read(ref reader, typeToConvert, options);

    public override CKeyValuePair? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
        {
            return null;
        }

        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        reader.Read();
        if (reader.TokenType != JsonTokenType.PropertyName)
        {
            throw new JsonException();
        }

        var propertyName = reader.GetString();
        if (propertyName != "Type")
        {
            throw new JsonException();
        }

        reader.Read();
        if (reader.TokenType != JsonTokenType.String)
        {
            throw new JsonException();
        }
        var (valType, _) = RedReflection.GetCSTypeFromRedType(reader.GetString());
        if (valType == null)
        {
            throw new JsonException();
        }

        reader.Read();
        if (reader.TokenType != JsonTokenType.PropertyName)
        {
            throw new JsonException();
        }

        propertyName = reader.GetString();

        object? result;
        var converter = options.GetConverter(valType);
        if (converter is ICustomRedConverter conv)
        {
            reader.Read();
            result = conv.ReadRedType(ref reader, valType, options);
        }
        else
        {
            result = JsonSerializer.Deserialize(ref reader, valType, options);
        }

        if (result is not IRedType val)
        {
            throw new JsonException();
        }

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndObject)
        {
            throw new JsonException();
        }

        return new CKeyValuePair(propertyName, val);
    }

    public override void Write(Utf8JsonWriter writer, CKeyValuePair value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        var valType = RedReflection.GetRedTypeFromCSType(value.Value.GetType());
        writer.WriteString("Type", valType);

        writer.WritePropertyName(value.Key);
        JsonSerializer.Serialize(writer, (object)value.Value, options);

        writer.WriteEndObject();
    }
}

#endregion Internal

#region ArrayConverter

public class ArrayConverterFactory : JsonConverterFactory
{
    private readonly CArrayConverter _cArrayConverter = new();
    private readonly CArrayFixedSizeConverter _cArrayFixedSizeConverter = new();
    private readonly CStaticConverter _cStaticConverter = new();

    public override bool CanConvert(Type typeToConvert) => typeof(IRedArray).IsAssignableFrom(typeToConvert);

    public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        if (typeToConvert.GetGenericTypeDefinition() == typeof(CArray<>))
        {
            return _cArrayConverter;
        }

        if (typeToConvert.GetGenericTypeDefinition() == typeof(CArrayFixedSize<>))
        {
            return _cArrayFixedSizeConverter;
        }

        if (typeToConvert.GetGenericTypeDefinition() == typeof(CStatic<>))
        {
            return _cStaticConverter;
        }

        throw new NotSupportedException("CreateConverter got called on a type that this converter factory doesn't support");
    }
}

public class CArrayConverter : JsonConverter<IRedArray>, ICustomRedConverter
{
    public object? ReadRedType(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => Read(ref reader, typeToConvert, options);

    public override IRedArray? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
        {
            return null;
        }

        if (reader.TokenType != JsonTokenType.StartArray)
        {
            throw new JsonException();
        }

        var arr = (IRedArray)RedTypeManager.CreateRedType(typeToConvert);
        var converter = options.GetConverter(arr.InnerType) as ICustomRedConverter;

        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndArray)
            {
                return arr;
            }

            object? val;
            if (converter != null)
            {
                val = converter.ReadRedType(ref reader, arr.InnerType, options);
            }
            else
            {
                val = JsonSerializer.Deserialize(ref reader, arr.InnerType, options);
            }

            arr.Add(val);
        }

        throw new JsonException();
    }

    public override void Write(Utf8JsonWriter writer, IRedArray value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();
        foreach (var entry in value)
        {
            JsonSerializer.Serialize(writer, entry, options);
        }
        writer.WriteEndArray();
    }
}

public class CArrayFixedSizeConverter : JsonConverter<IRedArray>, ICustomRedConverter
{
    public object? ReadRedType(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => Read(ref reader, typeToConvert, options);

    public override IRedArray? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
        {
            return null;
        }

        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        IRedArray? arr = null;
        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndObject)
            {
                if (arr == null)
                {
                    throw new JsonException();
                }

                return arr;
            }

            if (reader.TokenType != JsonTokenType.PropertyName)
            {
                throw new JsonException();
            }

            var propertyName = reader.GetString();
            switch (propertyName)
            {
                case "Size":
                {
                    reader.Read();
                    if (reader.TokenType != JsonTokenType.Number)
                    {
                        throw new JsonException();
                    }

                    var size = reader.GetInt32();
                    arr = (IRedArray)RedTypeManager.CreateRedType(typeToConvert, size);

                    break;
                }

                case "Elements":
                {
                    if (arr == null)
                    {
                        throw new JsonException();
                    }

                    reader.Read();
                    if (reader.TokenType != JsonTokenType.StartArray)
                    {
                        throw new JsonException();
                    }

                    var counter = 0;
                    while (reader.Read())
                    {
                        if (reader.TokenType == JsonTokenType.EndArray)
                        {
                            break;
                        }

                        var converter = options.GetConverter(arr.InnerType);
                        if (converter is ICustomRedConverter conv)
                        {
                            arr[counter++] = conv.ReadRedType(ref reader, arr.InnerType, options);
                        }
                        else
                        {
                            arr[counter++] = JsonSerializer.Deserialize(ref reader, arr.InnerType, options);
                        }
                    }

                    break;
                }

                default:
                {
                    throw new JsonException();
                }
            }
        }

        throw new JsonException();
    }

    public override void Write(Utf8JsonWriter writer, IRedArray value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        writer.WriteNumber("Size", value.Count);

        writer.WritePropertyName("Elements");
        writer.WriteStartArray();
        foreach (var entry in value)
        {
            JsonSerializer.Serialize(writer, entry, options);
        }
        writer.WriteEndArray();

        writer.WriteEndObject();
    }
}

public class CStaticConverter : JsonConverter<IRedArray>, ICustomRedConverter
{
    public object? ReadRedType(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => Read(ref reader, typeToConvert, options);

    public override IRedArray? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
        {
            return null;
        }

        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        IRedArray? arr = null;
        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndObject)
            {
                if (arr == null)
                {
                    throw new JsonException();
                }

                return arr;
            }

            if (reader.TokenType != JsonTokenType.PropertyName)
            {
                throw new JsonException();
            }

            var propertyName = reader.GetString();
            switch (propertyName)
            {
                case "Size":
                {
                    reader.Read();
                    if (reader.TokenType != JsonTokenType.Number)
                    {
                        throw new JsonException();
                    }

                    var size = reader.GetInt32();
                    arr = (IRedArray)RedTypeManager.CreateRedType(typeToConvert, size);

                    break;
                }

                case "MaxSize":
                {
                    if (arr == null)
                    {
                        throw new JsonException();
                    }

                    reader.Read();
                    if (reader.TokenType != JsonTokenType.Number)
                    {
                        throw new JsonException();
                    }

                    arr.MaxSize = reader.GetInt32();

                    break;
                }

                case "Elements":
                {
                    if (arr == null)
                    {
                        throw new JsonException();
                    }

                    reader.Read();
                    if (reader.TokenType != JsonTokenType.StartArray)
                    {
                        throw new JsonException();
                    }

                    var counter = 0;
                    while (reader.Read())
                    {
                        if (reader.TokenType == JsonTokenType.EndArray)
                        {
                            break;
                        }

                        var converter = options.GetConverter(arr.InnerType);
                        if (converter is ICustomRedConverter conv)
                        {
                            arr[counter++] = conv.ReadRedType(ref reader, arr.InnerType, options);
                        }
                        else
                        {
                            arr[counter++] = JsonSerializer.Deserialize(ref reader, arr.InnerType, options);
                        }
                    }

                    break;
                }

                default:
                {
                    throw new JsonException();
                }
            }
        }

        throw new JsonException();
    }

    public override void Write(Utf8JsonWriter writer, IRedArray value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        writer.WriteNumber("Size", value.Count);
        writer.WriteNumber("MaxSize", value.MaxSize);

        writer.WritePropertyName("Elements");
        writer.WriteStartArray();
        foreach (var entry in value)
        {
            JsonSerializer.Serialize(writer, entry, options);
        }
        writer.WriteEndArray();

        writer.WriteEndObject();
    }
}

#endregion ArrayConverter

#region EnumConverter

public class EnumConverterFactory : JsonConverterFactory
{
    private readonly CBitFieldConverter _cBitFieldConverter = new();
    private readonly CEnumConverter _cEnumConverter = new();

    public override bool CanConvert(Type typeToConvert) => typeof(IRedBitField).IsAssignableFrom(typeToConvert) || typeof(IRedEnum).IsAssignableFrom(typeToConvert);

    public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        if (typeof(IRedBitField).IsAssignableFrom(typeToConvert))
        {
            return _cBitFieldConverter;
        }

        if (typeof(IRedEnum).IsAssignableFrom(typeToConvert))
        {
            return _cEnumConverter;
        }

        throw new NotSupportedException("CreateConverter got called on a type that this converter factory doesn't support");
    }
}

public class CBitFieldConverter : JsonConverter<IRedBitField>, ICustomRedConverter
{
    public object ReadRedType(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => Read(ref reader, typeToConvert, options);

    public override IRedBitField Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
        {
            return (IRedBitField)RedTypeManager.CreateRedType(typeToConvert);
        }

        if (reader.TokenType != JsonTokenType.String)
        {
            throw new JsonException();
        }

        var enumType = typeToConvert.GetGenericArguments()[0];
        var str = reader.GetString();
        return CBitField.Parse(enumType, str);
    }

    public override void Write(Utf8JsonWriter writer, IRedBitField value, JsonSerializerOptions options) => writer.WriteStringValue(value.ToBitFieldString());
}

public class CEnumConverter : JsonConverter<IRedEnum>, ICustomRedConverter
{
    public object ReadRedType(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => Read(ref reader, typeToConvert, options);

    public override IRedEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
        {
            return (IRedEnum)RedTypeManager.CreateRedType(typeToConvert);
        }

        if (reader.TokenType != JsonTokenType.String)
        {
            throw new JsonException();
        }

        var enumType = typeToConvert.GetGenericArguments()[0];
        var str = reader.GetString();
        return CEnum.Parse(enumType, str);
    }

    public override void Write(Utf8JsonWriter writer, IRedEnum value, JsonSerializerOptions options) => writer.WriteStringValue(value.ToEnumString());
}

#endregion EnumConverter

#region HandleConverter

public class HandleConverterFactory : JsonConverterFactory
{
    private readonly HandleConverter _handleConverter;

    public HandleConverterFactory(ReferenceResolver<RedBaseClass> referenceResolver)
    {
        _handleConverter = new(referenceResolver);
    }

    public override bool CanConvert(Type typeToConvert) => typeof(IRedBaseHandle).IsAssignableFrom(typeToConvert);

    public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        if (typeToConvert.GetGenericTypeDefinition() == typeof(CHandle<>))
        {
            return _handleConverter;
        }

        if (typeToConvert.GetGenericTypeDefinition() == typeof(CWeakHandle<>))
        {
            return _handleConverter;
        }

        throw new NotSupportedException("CreateConverter got called on a type that this converter factory doesn't support");
    }
}

public class HandleConverter : JsonConverter<IRedBaseHandle>, ICustomRedConverter
{
    private readonly ReferenceResolver<RedBaseClass> _referenceResolver;

    public HandleConverter(ReferenceResolver<RedBaseClass> referenceResolver)
    {
        _referenceResolver = referenceResolver;
    }

    public override bool HandleNull => true;

    public object? ReadRedType(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => Read(ref reader, typeToConvert, options);

    public override IRedBaseHandle? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
        {
            return null;
        }

        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        string? id = null;
        var handle = (IRedBaseHandle)RedTypeManager.CreateRedType(typeToConvert);

        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndObject)
            {
                return handle;
            }

            if (reader.TokenType != JsonTokenType.PropertyName)
            {
                throw new JsonException();
            }

            var propertyName = reader.GetString();
            reader.Read();

            switch (propertyName)
            {
                case "HandleId":
                {
                    if (reader.TokenType != JsonTokenType.String)
                    {
                        throw new JsonException();
                    }

                    id = reader.GetString();

                    break;
                }

                case "Data":
                {
                    if (id == null)
                    {
                        throw new JsonException();
                    }

                    if (reader.TokenType != JsonTokenType.StartObject)
                    {
                        throw new JsonException();
                    }

                    var conv = (RedClassConverter)options.GetConverter(typeof(RedBaseClass));
                    handle.SetValue(conv.CustomRead(ref reader, typeof(RedBaseClass), options, id));

                    break;
                }

                case "HandleRefId":
                {
                    if (reader.TokenType != JsonTokenType.String)
                    {
                        throw new JsonException();
                    }

                    var refId = reader.GetString();
                    if (refId == null)
                    {
                        throw new JsonException();
                    }

                    if (refId != "-1")
                    {
                        handle.SetValue(_referenceResolver.ResolveReference(refId));
                    }

                    break;
                }

                default:
                {
                    throw new JsonException();
                }
            }
        }

        throw new JsonException();
    }

    public override void Write(Utf8JsonWriter writer, IRedBaseHandle? value, JsonSerializerOptions options)
    {
        if (value == null)
        {
            writer.WriteNullValue();
        }
        else
        {
            writer.WriteStartObject();

            var cls = value.GetValue();
            if (cls != null)
            {
                var refId = _referenceResolver.GetReference(cls, out var alreadyExists);
                if (alreadyExists)
                {
                    writer.WriteString("HandleRefId", refId);
                }
                else
                {
                    writer.WriteString("HandleId", refId);

                    writer.WritePropertyName("Data");
                    JsonSerializer.Serialize(writer, cls, options);
                }
            }
            else
            {
                writer.WriteString("HandleRefId", "-1");
            }

            writer.WriteEndObject();
        }
    }
}

#endregion HandleConverter

#region ResourceConverter

public class ResourceConverterFactory : JsonConverterFactory
{
    private readonly ResourceReferenceConverter _resourceReferenceConverter = new();

    public override bool CanConvert(Type typeToConvert) => typeof(IRedResourceReference).IsAssignableFrom(typeToConvert) || typeof(IRedResourceAsyncReference).IsAssignableFrom(typeToConvert);

    public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        if (typeof(IRedResourceReference).IsAssignableFrom(typeToConvert))
        {
            return _resourceReferenceConverter;
        }

        if (typeof(IRedResourceAsyncReference).IsAssignableFrom(typeToConvert))
        {
            return _resourceReferenceConverter;
        }

        throw new NotSupportedException("CreateConverter got called on a type that this converter factory doesn't support");
    }
}

public class ResourceReferenceConverter : JsonConverter<IRedRef>, ICustomRedConverter
{
    public object ReadRedType(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => Read(ref reader, typeToConvert, options);

    public override IRedRef Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
        {
            return (IRedRef)RedTypeManager.CreateRedType(typeToConvert);
        }

        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        var result = (IRedRef)RedTypeManager.CreateRedType(typeToConvert);
        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndObject)
            {
                return result;
            }

            if (reader.TokenType != JsonTokenType.PropertyName)
            {
                throw new JsonException();
            }

            var propertyName = reader.GetString();
            switch (propertyName)
            {
                case "DepotPath":
                {
                    var converter = options.GetConverter(typeof(CName));
                    if (converter is ICustomRedConverter conv)
                    {
                        reader.Read();
                        result.DepotPath = (CName?)conv.ReadRedType(ref reader, typeof(CName), options);
                    }
                    else
                    {
                        throw new JsonException();
                    }

                    break;
                }

                case "Flags":
                {
                    reader.Read();
                    if (reader.TokenType != JsonTokenType.String)
                    {
                        throw new JsonException();
                    }

                    var str = reader.GetString();
                    if (str == null)
                    {
                        throw new JsonException();
                    }

                    result.Flags = Enum.Parse<InternalEnums.EImportFlags>(str);
                    break;
                }

                default:
                {
                    throw new JsonException();
                }
            }
        }

        throw new JsonException();
    }

    public override void Write(Utf8JsonWriter writer, IRedRef value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        writer.WritePropertyName("DepotPath");
        JsonSerializer.Serialize(writer, value.DepotPath, options);

        writer.WriteString("Flags", value.Flags.ToString());

        writer.WriteEndObject();
    }
}

#endregion ResourceConverter

#region ClassConverter

public class ClassConverterFactory : JsonConverterFactory
{
    private readonly RedClassConverter _redBaseClassConverter;

    public ClassConverterFactory(ReferenceResolver<RedBaseClass> classResolver)
    {
        _redBaseClassConverter = new(classResolver);
    }

    public override bool CanConvert(Type typeToConvert) => typeToConvert.IsSubclassOf(typeof(RedBaseClass)) || typeToConvert == typeof(RedBaseClass);

    public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        if (typeToConvert.IsSubclassOf(typeof(RedBaseClass)) || typeToConvert == typeof(RedBaseClass))
        {
            return _redBaseClassConverter;
        }

        throw new NotSupportedException("CreateConverter got called on a type that this converter factory doesn't support");
    }
}

public class RedClassConverter : JsonConverter<RedBaseClass>, ICustomRedConverter
{
    private readonly ReferenceResolver<RedBaseClass> _referenceResolver;

    public RedClassConverter(ReferenceResolver<RedBaseClass> referenceResolver)
    {
        _referenceResolver = referenceResolver;
    }


    public object? ReadRedType(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => Read(ref reader, typeToConvert, options);

    public RedBaseClass? CustomRead(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options, string? refId)
    {
        if (reader.TokenType == JsonTokenType.Null)
        {
            return null;
        }

        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        RedReflection.ExtendedTypeInfo? typeInfo = null;

        RedBaseClass? cls = null;
        string? clsType;

        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndObject)
            {
                return cls;
            }

            if (reader.TokenType != JsonTokenType.PropertyName)
            {
                throw new JsonException();
            }

            var propertyName = reader.GetString();
            reader.Read();

            switch (propertyName)
            {
                case "Type":
                {
                    if (reader.TokenType != JsonTokenType.String)
                    {
                        throw new JsonException();
                    }

                    clsType = reader.GetString();

                    if (refId != null && _referenceResolver.HasReference(refId))
                    {
                        cls = _referenceResolver.ResolveReference(refId);
                    }
                    else
                    {
                        cls = RedTypeManager.Create(clsType);
                    }

                    typeInfo = RedReflection.GetTypeInfo(cls);

                    if (refId != null && !_referenceResolver.HasReference(refId))
                    {
                        _referenceResolver.AddReference(refId, cls);
                    }

                    break;
                }

                case "Properties":
                {
                    if (cls == null || typeInfo == null)
                    {
                        throw new JsonException();
                    }

                    if (reader.TokenType != JsonTokenType.StartObject)
                    {
                        throw new JsonException();
                    }

                    while (reader.Read())
                    {
                        if (reader.TokenType == JsonTokenType.EndObject)
                        {
                            break;
                        }

                        if (reader.TokenType != JsonTokenType.PropertyName)
                        {
                            throw new JsonException();
                        }

                        var key = reader.GetString();
                        if (key == null)
                        {
                            throw new JsonException();
                        }

                        var valInfo = typeInfo.PropertyInfos.FirstOrDefault(x => x.RedName == key);
                        if (valInfo == null)
                        {
                            throw new JsonException();
                        }

                        object? val;
                        var converter = options.GetConverter(valInfo.Type);
                        if (converter is ICustomRedConverter conv)
                        {
                            reader.Read();
                            val = conv.ReadRedType(ref reader, valInfo.Type, options);
                        }
                        else
                        {
                            val = JsonSerializer.Deserialize(ref reader, valInfo.Type, options);
                        }

                        if (!typeInfo.SerializeDefault && RedReflection.IsDefault(cls.GetType(), valInfo.RedName, val))
                        {
                            continue;
                        }

                        cls.SetProperty(valInfo.RedName, (IRedType?)val);
                    }

                    break;
                }

                default:
                {
                    throw new JsonException();
                }
            }
        }

        throw new JsonException();
    }

    public override RedBaseClass? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => CustomRead(ref reader, typeToConvert, options, null);

    public override void Write(Utf8JsonWriter writer, RedBaseClass value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        writer.WriteString("Type", RedReflection.GetRedTypeFromCSType(value.GetType()));

        writer.WritePropertyName("Properties");
        writer.WriteStartObject();

        var typeInfo = RedReflection.GetTypeInfo(value);
        foreach (var propertyInfo in typeInfo.PropertyInfos.OrderBy(x => x.RedName))
        {
            writer.WritePropertyName(propertyInfo.RedName);
            JsonSerializer.Serialize(writer, (object)value.GetProperty(propertyInfo.RedName), options);
        }

        writer.WriteEndObject();

        writer.WriteEndObject();
    }
}

#endregion ClassConverter

#region Red4FileConverter

public class Red4FileConverterFactory : JsonConverterFactory
{
    private readonly RedPackageConverter _redPackageConverter = new();

    public override bool CanConvert(Type typeToConvert) => typeToConvert.IsSubclassOf(typeof(Red4File));

    public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        if (typeToConvert == typeof(RedPackage))
        {
            return _redPackageConverter;
        }

        throw new NotSupportedException("CreateConverter got called on a type that this converter factory doesn't support");
    }
}

public class RedPackageConverter : JsonConverter<RedPackage>, ICustomRedConverter
{
    public object? ReadRedType(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => Read(ref reader, typeToConvert, options);

    public override RedPackage? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
        {
            return null;
        }

        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        var result = new RedPackage();
        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndObject)
            {
                return result;
            }

            if (reader.TokenType != JsonTokenType.PropertyName)
            {
                throw new JsonException();
            }

            var propertyName = reader.GetString();
            switch (propertyName)
            {
                case "Version":
                {
                    reader.Read();
                    if (reader.TokenType != JsonTokenType.Number)
                    {
                        throw new JsonException();
                    }

                    result.Version = reader.GetUInt16();
                    break;
                }

                case "Sections":
                {
                    reader.Read();
                    if (reader.TokenType != JsonTokenType.Number)
                    {
                        throw new JsonException();
                    }

                    result.Sections = reader.GetUInt16();
                    break;
                }

                case "CruidIndex":
                {
                    reader.Read();
                    if (reader.TokenType != JsonTokenType.Number)
                    {
                        throw new JsonException();
                    }

                    result.CruidIndex = reader.GetInt16();
                    break;
                }

                case "RootCruids":
                {
                    reader.Read();
                    if (reader.TokenType != JsonTokenType.StartArray)
                    {
                        throw new JsonException();
                    }

                    while (reader.Read())
                    {
                        if (reader.TokenType == JsonTokenType.EndArray)
                        {
                            break;
                        }

                        result.RootCruids.Add(reader.GetUInt64());
                    }

                    break;
                }

                case "Chunks":
                {
                    reader.Read();
                    if (reader.TokenType != JsonTokenType.StartArray)
                    {
                        throw new JsonException();
                    }

                    result.Chunks = new List<RedBaseClass>();
                    while (reader.Read())
                    {
                        if (reader.TokenType == JsonTokenType.EndArray)
                        {
                            break;
                        }

                        var converter = options.GetConverter(typeof(RedBaseClass));
                        if (converter is ICustomRedConverter conv)
                        {
                            result.Chunks.Add((RedBaseClass?)conv.ReadRedType(ref reader, typeof(RedBaseClass), options));
                        }
                        else
                        {
                            throw new JsonException();
                        }
                    }

                    break;
                }

                default:
                {
                    throw new JsonException();
                }
            }
        }

        throw new JsonException();
    }

    public override void Write(Utf8JsonWriter writer, RedPackage value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        writer.WriteNumber("Version", value.Version);
        writer.WriteNumber("Sections", value.Sections);
        writer.WriteNumber("CruidIndex", value.CruidIndex);

        writer.WritePropertyName("RootCruids");
        writer.WriteStartArray();
        foreach (var cruid in value.RootCruids)
        {
            writer.WriteNumberValue(cruid);
        }
        writer.WriteEndArray();

        writer.WritePropertyName("Chunks");
        writer.WriteStartArray();
        foreach (var chunk in value.Chunks)
        {
            JsonSerializer.Serialize(writer, chunk, options);
        }
        writer.WriteEndArray();

        writer.WriteEndObject();
    }
}

#endregion Red4FileConverter

public class ReferenceResolver<T> where T : class
{
    private readonly ConcurrentDictionary<int, uint> _threadedReferenceCount = new();

    private readonly ConcurrentDictionary<int, Dictionary<string, T>> _threadedReferenceIdToObjectMap = new();
    private readonly ConcurrentDictionary<int, Dictionary<T, string>> _threadedObjectToReferenceIdMap = new();

    public void Begin()
    {
        _threadedReferenceCount.TryAdd(Environment.CurrentManagedThreadId, 0);
        _threadedReferenceIdToObjectMap.TryAdd(Environment.CurrentManagedThreadId, new Dictionary<string, T>());
        _threadedObjectToReferenceIdMap.TryAdd(Environment.CurrentManagedThreadId, new Dictionary<T, string>(ReferenceEqualityComparer.Instance));
    }

    public void End()
    {
        _threadedReferenceCount.TryRemove(Environment.CurrentManagedThreadId, out _);
        _threadedReferenceIdToObjectMap.TryRemove(Environment.CurrentManagedThreadId, out _);
        _threadedObjectToReferenceIdMap.TryRemove(Environment.CurrentManagedThreadId, out _);
    }

    private uint GetNextId() => _threadedReferenceCount[Environment.CurrentManagedThreadId]++;

    private Dictionary<string, T> ReferenceIdToObjectMap => _threadedReferenceIdToObjectMap[Environment.CurrentManagedThreadId];
    private Dictionary<T, string> ObjectToReferenceIdMap => _threadedObjectToReferenceIdMap[Environment.CurrentManagedThreadId];

    public void AddReference(string referenceId, T value)
    {
        if (!ReferenceIdToObjectMap.TryAdd(referenceId, value))
        {
            throw new JsonException();
        }
    }

    public string GetReference(T value, out bool alreadyExists)
    {
        if (ObjectToReferenceIdMap.TryGetValue(value, out var referenceId))
        {
            alreadyExists = true;
        }
        else
        {
            referenceId = GetNextId().ToString();
            ObjectToReferenceIdMap.Add(value, referenceId);
            alreadyExists = false;
        }

        return referenceId;
    }

    public bool HasReference(string referenceId) => ReferenceIdToObjectMap.ContainsKey(referenceId);

    public T ResolveReference(string referenceId)
    {
        if (!ReferenceIdToObjectMap.TryGetValue(referenceId, out var value))
        {
            throw new JsonException();
        }

        return value;
    }
}

public class SemVersionConverter : JsonConverter<SemVersion>
{
    public override SemVersion? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => reader.GetString();

    public override void Write(Utf8JsonWriter writer, SemVersion value, JsonSerializerOptions options) => writer.WriteStringValue(value.ToString());
}

public class RedFileDtoConverter : JsonConverter<RedFileDto>, ICustomRedConverter
{
    private readonly ReferenceResolver<RedBaseClass> _referenceResolver;

    public RedFileDtoConverter(ReferenceResolver<RedBaseClass> referenceResolver)
    {
        _referenceResolver = referenceResolver;
    }

    public object? ReadRedType(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => Read(ref reader, typeToConvert, options);

    public override RedFileDto Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        RedFileDto result = new();

        reader.Read();
        if (reader.TokenType != JsonTokenType.PropertyName)
        {
            throw new JsonException();
        }

        var propertyName = reader.GetString();
        if (propertyName != "Header")
        {
            throw new JsonException();
        }

        result.Header = JsonSerializer.Deserialize<JsonHeader>(ref reader, options);
        if (result.Header == null)
        {
            throw new JsonException("Invalid JSON format");
        }

        if (result.Header!.WKitJsonVersion > new JsonHeader().WKitJsonVersion)
        {
            throw new JsonException("This JSON was created with a newer version of WKit!");
        }

        reader.Read();
        if (reader.TokenType != JsonTokenType.PropertyName)
        {
            throw new JsonException();
        }

        propertyName = reader.GetString();
        if (propertyName != "Data")
        {
            throw new JsonException();
        }
        reader.Read();

        switch (result.Header!.DataType)
        {
            case DataTypes.CR2W:
            {
                result.Data = ReadRegular(ref reader, options);
                break;
            }

            case DataTypes.CR2WFlat:
            {
                result.Data = ReadFlat(ref reader, options);
                break;
            }

            default:
            {
                throw new JsonException();
            }
        }

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndObject)
        {
            throw new JsonException();
        }

        return result;
    }

    private CR2WFile ReadRegular(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        var result = new CR2WFile();

        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndObject)
            {
                break;
            }

            if (reader.TokenType != JsonTokenType.PropertyName)
            {
                throw new JsonException();
            }

            var propertyName = reader.GetString();
            reader.Read();

            switch (propertyName)
            {
                case "Version":
                {
                    if (reader.TokenType != JsonTokenType.Number)
                    {
                        throw new JsonException();
                    }

                    result.MetaData.Version = reader.GetUInt32();

                    break;
                }

                case "BuildVersion":
                {
                    if (reader.TokenType != JsonTokenType.Number)
                    {
                        throw new JsonException();
                    }

                    result.MetaData.BuildVersion = reader.GetUInt32();

                    break;
                }

                case "RootChunk":
                {
                    var converter = options.GetConverter(typeof(RedBaseClass));
                    if (converter is ICustomRedConverter conv)
                    {
                        result.RootChunk = (RedBaseClass?)conv.ReadRedType(ref reader, typeof(RedBaseClass), options);
                    }
                    else
                    {
                        throw new JsonException();
                    }

                    break;
                }

                case "EmbeddedFiles":
                {
                    if (reader.TokenType != JsonTokenType.StartArray)
                    {
                        throw new JsonException();
                    }

                    while (reader.Read())
                    {
                        if (reader.TokenType == JsonTokenType.EndArray)
                        {
                            break;
                        }

                        result.EmbeddedFiles.Add(JsonSerializer.Deserialize<CR2WEmbedded>(ref reader, options));
                    }

                    break;
                }

                default:
                {
                    throw new JsonException();
                }
            }
        }

        return result;
    }

    private CR2WFile ReadFlat(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        var result = new CR2WFile();

        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndObject)
            {
                break;
            }

            if (reader.TokenType != JsonTokenType.PropertyName)
            {
                throw new JsonException();
            }

            var propertyName = reader.GetString();
            reader.Read();

            switch (propertyName)
            {
                case "Version":
                {
                    if (reader.TokenType != JsonTokenType.Number)
                    {
                        throw new JsonException();
                    }

                    result.MetaData.Version = reader.GetUInt32();

                    break;
                }

                case "BuildVersion":
                {
                    if (reader.TokenType != JsonTokenType.Number)
                    {
                        throw new JsonException();
                    }

                    result.MetaData.BuildVersion = reader.GetUInt32();

                    break;
                }

                case "RootChunk":
                {
                    if (reader.TokenType != JsonTokenType.StartObject)
                    {
                        throw new JsonException();
                    }

                    result.RootChunk = JsonSerializer.Deserialize<RedBaseClass>(ref reader, options);

                    break;
                }

                case "EmbeddedFiles":
                {
                    if (reader.TokenType != JsonTokenType.StartArray)
                    {
                        throw new JsonException();
                    }

                    while (reader.Read())
                    {
                        if (reader.TokenType == JsonTokenType.EndArray)
                        {
                            break;
                        }

                        result.EmbeddedFiles.Add(JsonSerializer.Deserialize<CR2WEmbedded>(ref reader, options));
                    }

                    break;
                }

                case "ChunkReferences":
                {
                    if (reader.TokenType != JsonTokenType.StartArray)
                    {
                        throw new JsonException();
                    }

                    var chunkList = JsonSerializer.Deserialize<List<JsonElement>>(ref reader, options)!;

                    for (var i = 0; i < chunkList.Count; i++)
                    {
                        var type = chunkList[i].GetProperty("Type").GetString();
                        _referenceResolver.AddReference(i.ToString(), RedTypeManager.Create(type));
                    }

                    var conv = (RedClassConverter)options.GetConverter(typeof(RedBaseClass));
                    for (var i = 0; i < chunkList.Count; i++)
                    {
                        var bufferWriter = new ArrayBufferWriter<byte>();
                        using (var writer = new Utf8JsonWriter(bufferWriter))
                        {
                            chunkList[i].WriteTo(writer);
                        }

                        var subReader = new Utf8JsonReader(bufferWriter.WrittenSpan, reader.CurrentState.Options);
                        subReader.Read();

                        conv.CustomRead(ref subReader, typeof(RedBaseClass), options, i.ToString());
                    }

                    break;
                }

                default:
                {
                    throw new JsonException();
                }
            }
        }

        return result;
    }

    public override void Write(Utf8JsonWriter writer, RedFileDto value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        writer.WritePropertyName("Header");
        JsonSerializer.Serialize(writer, value.Header, options);

        writer.WritePropertyName("Data");
        switch (value.Header.DataType)
        {
            case DataTypes.CR2W:
            {
                WriteRegular(writer, value.Data, options);
                break;
            }

            case DataTypes.CR2WFlat:
            {
                WriteFlat(writer, value, options);
                break;
            }

            default:
            {
                throw new JsonException();
            }
        }

        writer.WriteEndObject();
    }

    private void WriteRegular(Utf8JsonWriter writer, CR2WFile value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        writer.WriteNumber("Version", value.MetaData.Version);
        writer.WriteNumber("BuildVersion", value.MetaData.BuildVersion);

        writer.WritePropertyName("RootChunk");
        JsonSerializer.Serialize(writer, value.RootChunk, options);

        writer.WritePropertyName("EmbeddedFiles");
        writer.WriteStartArray();
        foreach (var embeddedFile in value.EmbeddedFiles)
        {
            JsonSerializer.Serialize(writer, embeddedFile, options);
        }
        writer.WriteEndArray();

        writer.WriteEndObject();
    }

    private void WriteFlat(Utf8JsonWriter writer, RedFileDto value, JsonSerializerOptions options)
    {
        var chunks = value.GetChunkList();
        foreach (var chunk in chunks)
        {
            _referenceResolver.GetReference(chunk, out _);
        }

        writer.WriteStartObject();

        writer.WriteNumber("Version", value.Data.MetaData.Version);
        writer.WriteNumber("BuildVersion", value.Data.MetaData.BuildVersion);

        writer.WritePropertyName("ChunkReferences");
        JsonSerializer.Serialize(writer, chunks, options);

        writer.WritePropertyName("RootChunk");
        JsonSerializer.Serialize(writer, value.Data.RootChunk, options);

        writer.WritePropertyName("EmbeddedFiles");
        writer.WriteStartArray();
        foreach (var embeddedFile in value.Data.EmbeddedFiles)
        {
            JsonSerializer.Serialize(writer, embeddedFile, options);
        }
        writer.WriteEndArray();

        writer.WriteEndObject();
    }
}


public static class RedJsonSerializer
{
    private static readonly ReferenceResolver<RedBuffer> s_bufferResolver;
    private static readonly ReferenceResolver<RedBaseClass> s_classResolver;

    static RedJsonSerializer()
    {
        s_bufferResolver = new();
        s_classResolver = new();

        Options = new()
        {
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
            WriteIndented = true,
            MaxDepth = 2048,
            Converters =
            {
                new CBoolConverter(),
                new CDoubleConverter(),
                new CFloatConverter(),
                new CInt8Converter(),
                new CInt16Converter(),
                new CInt32Converter(),
                new CInt64Converter(),
                new CUInt8Converter(),
                new CUInt16Converter(),
                new CUInt32Converter(),
                new CUInt64Converter(),
                new CDateTimeConverter(),
                new CGuidConverter(),
                new CNameConverter(),
                new CRUIDConverter(),
                new CStringConverter(),
                new CVariantConverter(),
                new BufferConverterFactory(s_bufferResolver),
                new LocalizationStringConverter(),
                new CLegacySingleChannelCurveConverterFactory(),
                new MultiChannelCurveConverterFactory(),
                new NodeRefConverter(),
                new TweakDBIDConverter(),
                new CByteArrayConverter(),
                new CKeyValuePairConverter(),
                new ArrayConverterFactory(),
                new EnumConverterFactory(),
                new HandleConverterFactory(s_classResolver),
                new ResourceConverterFactory(),
                new ClassConverterFactory(s_classResolver),
                new Red4FileConverterFactory(),
                new SemVersionConverter(),
                new RedFileDtoConverter(s_classResolver)
            }
        };
    }

    public static JsonSerializerOptions Options { get; }

    public static string Serialize(object value)
    {
        s_bufferResolver.Begin();
        s_classResolver.Begin();

        var result = JsonSerializer.Serialize(value, Options);

        s_bufferResolver.End();
        s_classResolver.End();

        return result;
    }

    public static T? Deserialize<T>(string json)
    {
        s_bufferResolver.Begin();
        s_classResolver.Begin();

        var result = JsonSerializer.Deserialize<T>(json, Options);

        s_bufferResolver.End();
        s_classResolver.End();

        return result;
    }
}
