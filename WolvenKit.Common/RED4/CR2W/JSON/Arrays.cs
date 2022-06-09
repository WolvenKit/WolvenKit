#nullable enable
using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.CR2W.JSON;

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

        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndArray)
            {
                return arr;
            }

            object? val;
            if (options.GetConverter(arr.InnerType) is ICustomRedConverter converter)
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
