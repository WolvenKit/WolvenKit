using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using WolvenKit.Common.Conversion;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.CR2W.JSON;

public class CDateTimeConverter : CustomRedConverter<CDateTime>
{
    public override CDateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        JsonSerializer.Deserialize<ulong>(ref reader, options);

    public override void Write(Utf8JsonWriter writer, CDateTime value, JsonSerializerOptions options) =>
        JsonSerializer.Serialize(writer, (ulong)value, options);
}

public class CGuidConverter : CustomRedConverter<CGuid>
{
    public override CGuid Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => reader.GetBytesFromBase64();

    public override void Write(Utf8JsonWriter writer, CGuid value, JsonSerializerOptions options) => writer.WriteBase64StringValue((byte[])value);
}

public class CNameConverter : CustomRedConverter<CName>
{
    public override CName Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (RedJsonSerializer.IsOlderThen("0.0.7"))
        {
            return ReadV1(ref reader, typeToConvert, options);
        }

        return ReadV2(ref reader, typeToConvert, options);
    }

    public CName ReadV1(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
        {
            return (CName)RedTypeManager.CreateRedType(typeToConvert);
        }

        if (reader.TokenType == JsonTokenType.Number)
        {
            return reader.GetUInt64();
        }

        if (reader.TokenType == JsonTokenType.String)
        {
            var str = reader.GetString();
            if (str == null)
            {
                throw new JsonException();
            }

            if (ulong.TryParse(str, out var value))
            {
                return value;
            }

            return str;
        }

        throw new JsonException();
    }

    public CName ReadV2(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        var dict = JsonSerializer.Deserialize<Dictionary<string, string>>(ref reader, options);
        if (dict == null || dict.Count != 3)
        {
            throw new JsonException();
        }

        if (dict["$type"] != nameof(CName))
        {
            throw new JsonException();
        }

        switch (dict["$storage"])
        {
            case "string":
                return dict["$value"];

            case "uint64":
                return ulong.Parse(dict["$value"]);

            default:
                throw new JsonException();
        }
    }

    public override void Write(Utf8JsonWriter writer, CName value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        writer.WriteString("$type", "CName");
        if (value.TryGetResolvedText(out var str))
        {
            writer.WriteString("$storage", "string");
            writer.WriteString("$value", str);
        }
        else
        {
            writer.WriteString("$storage", "uint64");
            writer.WriteString("$value", ((ulong)value).ToString());
        }
        
        writer.WriteEndObject();
    }
}

public class CRUIDConverter : CustomRedConverter<CRUID>
{
    public override CRUID Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        JsonSerializer.Deserialize<ulong>(ref reader, options);

    public override void Write(Utf8JsonWriter writer, CRUID value, JsonSerializerOptions options) =>
        JsonSerializer.Serialize(writer, (ulong)value, options);
}

public class CStringConverter : CustomRedConverter<CString>
{
    public override CString Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
        {
            return (CString)RedTypeManager.CreateRedType(typeToConvert);
        }

        return reader.GetString().NotNull();
    }

    public override void Write(Utf8JsonWriter writer, CString value, JsonSerializerOptions options) => writer.WriteStringValue(value);
}

public class CVariantConverter : CustomRedConverter<CVariant>
{
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
                    if (type is { IsGenericType: true } && (type.GetGenericTypeDefinition() == typeof(CHandle<>) || type.GetGenericTypeDefinition() == typeof(CWeakHandle<>)))
                    {
                        return new CVariant { Value = RedTypeManager.CreateRedType(type) };
                    }

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
                    if (!RedJsonSerializer.IsVersion("0.0.1") || reader.TokenType != JsonTokenType.String)
                    {
                        throw new JsonException();
                    }

                    (type, _) = RedReflection.GetCSTypeFromRedType(reader.GetString().NotNull());
                    break;
                }

                case "$type":
                {
                    if (!RedJsonSerializer.IsNewerThen("0.0.1") || reader.TokenType != JsonTokenType.String)
                    {
                        throw new JsonException();
                    }

                    (type, _) = RedReflection.GetCSTypeFromRedType(reader.GetString().NotNull());
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

        var redTypeName = RedReflection.GetRedTypeFromCSType(value.Value.NotNull().GetType());
        writer.WriteString("$type", redTypeName);

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

public class DataBufferConverter : CustomRedConverter<DataBuffer>
{
    private readonly ReferenceResolver<RedBuffer> _referenceResolver;

    public DataBufferConverter(ReferenceResolver<RedBuffer> referenceResolver) => _referenceResolver = referenceResolver;

    public override DataBuffer? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        IRedBufferWrapper? result = new DataBuffer();
        if (RedJsonSerializer.IsOlderThen("0.0.3"))
        {
            BufferHelper.ReadV1(ref reader, typeToConvert, options, _referenceResolver, ref result);
        }
        else
        {
            BufferHelper.ReadV2(ref reader, typeToConvert, options, _referenceResolver, ref result);
        }
        return (DataBuffer?)result;
    }

    public override void Write(Utf8JsonWriter writer, DataBuffer value, JsonSerializerOptions options) => BufferHelper.Write(writer, value, options, _referenceResolver);
}

public class SerializationDeferredDataBufferConverter : CustomRedConverter<SerializationDeferredDataBuffer>
{
    private readonly ReferenceResolver<RedBuffer> _referenceResolver;

    public SerializationDeferredDataBufferConverter(ReferenceResolver<RedBuffer> referenceResolver) => _referenceResolver = referenceResolver;

    public override SerializationDeferredDataBuffer? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        IRedBufferWrapper? result = new SerializationDeferredDataBuffer();
        if (RedJsonSerializer.IsOlderThen("0.0.4"))
        {
            BufferHelper.ReadV1(ref reader, typeToConvert, options, _referenceResolver, ref result);
        }
        else
        {
            BufferHelper.ReadV2(ref reader, typeToConvert, options, _referenceResolver, ref result);
        }
        return (SerializationDeferredDataBuffer?)result;
    }

    public override void Write(Utf8JsonWriter writer, SerializationDeferredDataBuffer value, JsonSerializerOptions options) => BufferHelper.Write(writer, value, options, _referenceResolver);
}

public class SharedDataBufferConverter : CustomRedConverter<SharedDataBuffer>
{
    public override SharedDataBuffer? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        IRedBufferWrapper? result = new SharedDataBuffer();
        if (RedJsonSerializer.IsOlderThen("0.0.4"))
        {
            return ReadV1(ref reader, typeToConvert, options);
        }
        else
        {
            BufferHelper.ReadV2(ref reader, typeToConvert, options, null, ref result);
        }
        return (SharedDataBuffer?)result;
    }

    public SharedDataBuffer? ReadV1(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
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
                    var obj = conv.ReadRedType(ref reader, typeof(RedFileDto), options)!;
                    val.Buffer.Data = new CR2WWrapper { File = ((RedFileDto)obj).Data! };
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

    public override void Write(Utf8JsonWriter writer, SharedDataBuffer value, JsonSerializerOptions options) => BufferHelper.Write(writer, value, options);
}

internal static class BufferHelper
{
    public static void ReadV1(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options, ReferenceResolver<RedBuffer> referenceResolver, ref IRedBufferWrapper? val)
    {
        if (reader.TokenType == JsonTokenType.Null)
        {
            val = null;
            return;
        }

        if (val == null)
        {
            throw new JsonException();
        }

        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        string? id = null;

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

                    val.Buffer = referenceResolver.ResolveReference(refId);

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
            referenceResolver.AddReference(id, val.Buffer);
        }
    }

    public static void ReadV2(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options, ReferenceResolver<RedBuffer>? referenceResolver, ref IRedBufferWrapper? val)
    {
        if (reader.TokenType == JsonTokenType.Null)
        {
            val = null;
            return;
        }

        if (val == null)
        {
            throw new JsonException();
        }

        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        string? id = null;
        uint flags = 0;

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
                case "BufferRefId":
                {
                    if (reader.TokenType != JsonTokenType.String)
                    {
                        throw new JsonException();
                    }

                    if (referenceResolver == null)
                    {
                        throw new JsonException();
                    }

                    var refId = reader.GetString();
                    if (refId == null)
                    {
                        throw new JsonException();
                    }

                    val.Buffer = referenceResolver.ResolveReference(refId);

                    break;
                }

                case "BufferId":
                {
                    if (reader.TokenType != JsonTokenType.String)
                    {
                        throw new JsonException();
                    }

                    if (referenceResolver == null)
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

                case "Flags":
                {
                    if (reader.TokenType != JsonTokenType.Number)
                    {
                        throw new JsonException();
                    }

                    flags = reader.GetUInt32();

                    break;
                }

                case "Type":
                {
                    if (reader.TokenType != JsonTokenType.String)
                    {
                        throw new JsonException();
                    }

                    var bufferType = reader.GetString();
                    if (bufferType == null)
                    {
                        throw new JsonException();
                    }
                    reader.Read();

                    propertyName = reader.GetString();
                    if (propertyName != "Data")
                    {
                        throw new JsonException();
                    }
                    reader.Read();

                    var converter = options.GetConverter(typeof(IParseableBuffer));
                    if (converter is ICustomRedConverter conv)
                    {
                        val.Data = (IParseableBuffer?)conv.ReadRedType(ref reader, Type.GetType(bufferType)!, options);
                    }
                    else
                    {
                        throw new JsonException();
                    }

                    val.Buffer.Flags = flags;

                    break;
                }

                case "Bytes":
                {
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
            if (referenceResolver == null)
            {
                throw new JsonException();
            }

            referenceResolver.AddReference(id, val.Buffer);
        }
    }

    public static void Write(Utf8JsonWriter writer, IRedBufferWrapper value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        WriteData(writer, value, options);

        writer.WriteEndObject();
    }

    public static void Write(Utf8JsonWriter writer, IRedBufferWrapper value, JsonSerializerOptions options, ReferenceResolver<RedBuffer> referenceResolver)
    {
        writer.WriteStartObject();

        var refId = referenceResolver.GetReference(value.Buffer, out var alreadyExists);
        if (alreadyExists)
        {
            writer.WriteString("BufferRefId", refId);
        }
        else
        {
            writer.WriteString("BufferId", refId);
            WriteData(writer, value, options);
        }

        writer.WriteEndObject();
    }

    public static void WriteData(Utf8JsonWriter writer, IRedBufferWrapper value, JsonSerializerOptions options)
    {
        writer.WriteNumber("Flags", value.Buffer.Flags);

        if (value.Buffer.Data is CookedInstanceTransformsBuffer or CR2WList or RedPackage or worldNodeDataBuffer or WorldTransformsBuffer or CollisionBuffer or CR2WWrapper or FoliageBuffer or AnimFacialSetupBakedDataBuffer or AnimFacialSetupMainPosesDataBuffer or AnimFacialSetupCorrectivePosesDataBuffer)
        {
            writer.WriteString("Type", value.Buffer.Data.GetType().AssemblyQualifiedName);

            writer.WritePropertyName("Data");
            JsonSerializer.Serialize(writer, value.Buffer.Data, options);
        }
        else
        {
            writer.WritePropertyName("Bytes");
            writer.WriteBase64StringValue(value.Buffer.GetBytes());
        }
    }
}

#endregion BufferConverter

public class LocalizationStringConverter : CustomRedConverter<LocalizationString>
{
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
                    if (reader.TokenType != JsonTokenType.String && reader.TokenType != JsonTokenType.Number)
                    {
                        throw new JsonException();
                    }

                    result.Unk1 = JsonSerializer.Deserialize<ulong>(ref reader, options);
                    break;
                }

                case "value":
                {
                    reader.Read();
                    if (reader.TokenType != JsonTokenType.String)
                    {
                        throw new JsonException();
                    }

                    result.Value = reader.GetString().NotNull();
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

        writer.WritePropertyName("unk1");
        JsonSerializer.Serialize(writer, value.Unk1, options);

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

public class CLegacySingleChannelCurveConverter : CustomRedConverter<IRedLegacySingleChannelCurve>
{
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

public class MultiChannelCurveConverter : CustomRedConverter<IRedMultiChannelCurve>
{
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

public class ResourcePathConverter : CustomRedConverter<ResourcePath>
{
    public override ResourcePath Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (RedJsonSerializer.IsOlderThen("0.0.7"))
        {
            return ReadV1(ref reader, typeToConvert, options);
        }

        return ReadV2(ref reader, typeToConvert, options);
    }

    public ResourcePath ReadV1(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
        {
            return (ResourcePath)RedTypeManager.CreateRedType(typeToConvert);
        }

        if (reader.TokenType == JsonTokenType.Number)
        {
            return reader.GetUInt64();
        }

        if (reader.TokenType == JsonTokenType.String)
        {
            var str = reader.GetString();
            if (str == null)
            {
                throw new JsonException();
            }

            if (ulong.TryParse(str, out var value))
            {
                return value;
            }

            return str;
        }

        throw new JsonException();
    }

    public ResourcePath ReadV2(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        var dict = JsonSerializer.Deserialize<Dictionary<string, string>>(ref reader, options);
        if (dict == null || dict.Count != 3)
        {
            throw new JsonException();
        }

        if (dict["$type"] != nameof(ResourcePath))
        {
            throw new JsonException();
        }

        switch (dict["$storage"])
        {
            case "string":
                return dict["$value"];

            case "uint64":
                return ulong.Parse(dict["$value"]);

            default:
                throw new JsonException();
        }
    }

    public override void Write(Utf8JsonWriter writer, ResourcePath value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        writer.WriteString("$type", "ResourcePath");
        if (value.TryGetResolvedText(out var str))
        {
            writer.WriteString("$storage", "string");
            writer.WriteString("$value", str);
        }
        else
        {
            writer.WriteString("$storage", "uint64");
            writer.WriteString("$value", ((ulong)value).ToString());
        }

        writer.WriteEndObject();
    }
}

public class NodeRefConverter : CustomRedConverter<NodeRef>
{
    public override NodeRef Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (RedJsonSerializer.IsOlderThen("0.0.7"))
        {
            return ReadV1(ref reader, typeToConvert, options);
        }

        return ReadV2(ref reader, typeToConvert, options);
    }

    public NodeRef ReadV1(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
        {
            return (NodeRef)RedTypeManager.CreateRedType(typeToConvert);
        }

        if (reader.TokenType == JsonTokenType.Number)
        {
            return reader.GetUInt64();
        }

        if (reader.TokenType == JsonTokenType.String)
        {
            var str = reader.GetString();
            if (str == null)
            {
                throw new JsonException();
            }

            if (ulong.TryParse(str, out var value))
            {
                return value;
            }

            return str;
        }

        throw new JsonException();
    }

    public NodeRef ReadV2(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        var dict = JsonSerializer.Deserialize<Dictionary<string, string>>(ref reader, options);
        if (dict == null || dict.Count != 3)
        {
            throw new JsonException();
        }

        if (dict["$type"] != nameof(NodeRef))
        {
            throw new JsonException();
        }

        switch (dict["$storage"])
        {
            case "string":
                return dict["$value"];

            case "uint64":
                return ulong.Parse(dict["$value"]);

            default:
                throw new JsonException();
        }
    }

    public override void Write(Utf8JsonWriter writer, NodeRef value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        writer.WriteString("$type", "NodeRef");
        if (value.TryGetResolvedText(out var str))
        {
            writer.WriteString("$storage", "string");
            writer.WriteString("$value", str);
        }
        else
        {
            writer.WriteString("$storage", "uint64");
            writer.WriteString("$value", ((ulong)value).ToString());
        }

        writer.WriteEndObject();
    }
}

public class TweakDBIDConverter : CustomRedConverter<TweakDBID>
{
    public override TweakDBID Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (RedJsonSerializer.IsOlderThen("0.0.7"))
        {
            return ReadV1(ref reader, typeToConvert, options);
        }

        return ReadV2(ref reader, typeToConvert, options);
    }

    public TweakDBID ReadV1(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
        {
            return (TweakDBID)RedTypeManager.CreateRedType(typeof(TweakDBID));
        }

        if (reader.TokenType == JsonTokenType.Number)
        {
            return reader.GetUInt64();
        }

        if (reader.TokenType == JsonTokenType.String)
        {
            var str = reader.GetString();
            if (str == null)
            {
                throw new JsonException();
            }

            if (ulong.TryParse(str, out var value))
            {
                return value;
            }

            return str;
        }

        throw new JsonException();
    }

    public TweakDBID ReadV2(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        var dict = JsonSerializer.Deserialize<Dictionary<string, string>>(ref reader, options);
        if (dict == null || dict.Count != 3)
        {
            throw new JsonException();
        }

        if (dict["$type"] != nameof(TweakDBID))
        {
            throw new JsonException();
        }

        switch (dict["$storage"])
        {
            case "string":
                return dict["$value"];

            case "uint64":
                return ulong.Parse(dict["$value"]);

            default:
                throw new JsonException();
        }
    }

    public override void Write(Utf8JsonWriter writer, TweakDBID value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        writer.WriteString("$type", "TweakDBID");
        if (value.TryGetResolvedText(out var str))
        {
            writer.WriteString("$storage", "string");
            writer.WriteString("$value", str);
        }
        else
        {
            writer.WriteString("$storage", "uint64");
            writer.WriteString("$value", ((ulong)value).ToString());
        }

        writer.WriteEndObject();
    }
}
