#nullable enable
using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using WolvenKit.Common.Conversion;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.CR2W.JSON;

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

        //misplaced curly bracket ?!

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
